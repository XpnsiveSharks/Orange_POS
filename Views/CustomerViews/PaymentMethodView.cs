using Orange_POS.Models;
using Orange_POS.Repositories;
using Orange_POS.Services;
using Orange_POS.Views.CustomerViews.CustomerOrderingUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.CustomerViews
{
    public partial class PaymentMethodView : Form
    {
        private readonly OrderingService orderingService = new OrderingService();
        private readonly CustomerRepository customerRepository = new CustomerRepository();
        private readonly OrdersRepository ordersRepository = new OrdersRepository();
        public OrderListView OrderListViewReference { get; set; }

        private string customerNumber;
        private string orderNumber;
        private string dateAndTime;
        public event Action PaymentMethodBackButton;
        public List<OrdersUserControl> OrderItems { get; set; }
        public string OrderType { get; set; }
        public PaymentMethodView()
        {
            InitializeComponent();
        }
        private void HideOrderList()
        {
            this.Hide();
        }
        private void RestartApplication()
        {
            this.Close();
            var orderTypeView = new OrderTypeView();
            orderTypeView.Show();
        }
        public void PrintReceipt(string receiptContent)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                Font font = new Font("Arial", 10);
                float lineHeight = font.GetHeight();
                float x = 10;
                float y = 10;

                foreach (var line in receiptContent.Split('\n'))
                {
                    e.Graphics.DrawString(line, font, Brushes.Black, new PointF(x, y));
                    y += lineHeight;
                }
            };

            printDocument.Print();
        }
        public string GenerateReceiptContent(List<OrdersUserControl> orderItems, string paymentMethod)
        {
            StringBuilder receiptContent = new StringBuilder();
            double totalAmount = 0;
            receiptContent.AppendLine(dateAndTime);
            receiptContent.AppendLine("----------------------------------------------");
            receiptContent.AppendLine("              Receipt for Order               ");
            receiptContent.AppendLine("----------------------------------------------\n");

            foreach (var item in orderItems)
            {
                receiptContent.AppendLine($"{item.Product} x{item.Quantity} - ${item.TotalPrice}\nnote: {item.OrderNote}");
                totalAmount += item.TotalPrice;
            }

            receiptContent.AppendLine("\n--------------------------------------------");
            receiptContent.AppendLine($"Total: ${totalAmount}");
            receiptContent.AppendLine($"Payment Method: {paymentMethod}");
            receiptContent.AppendLine("----------------------------------------------\n");

            receiptContent.AppendLine($"order number: {orderNumber}");

            receiptContent.AppendLine("----------------------------------------------");
            receiptContent.AppendLine("      Thank you for your purchase!            ");

            return receiptContent.ToString();
        }
        private void CreateOrder(string paymentMethod)
        {
            customerNumber = orderingService.AddCustomer();
            var customerId = customerRepository.GetCustomerIdByCustomerNumber(customerNumber);
            dateAndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (customerId == 0)
            {
                MessageBox.Show("Invalid Customer ID. Please try again.");
                return;
            }
            var totalAmount = OrderItems.Sum(item => item.TotalPrice);
            orderNumber = orderingService.GenerateNumber("Order", orderingService.GetNumericPart(ordersRepository.GetOrderNumber()));
            var newOrder = new Orders
            {
                Order_Number = orderNumber,
                Order_Date = dateAndTime,
                Order_Type = OrderType,
                Customer_Id = customerId,
                Total_Amount = totalAmount,
                Status = "Pending",
                Payment_Method = paymentMethod
            };
            orderingService.OrderPlaced(newOrder);

            foreach (var orderItem in OrderItems)
            {
                var newOrderItems = new OrderItems
                {
                    Order_Id = ordersRepository.GetOrderIdByOrderNumber(orderNumber),
                    Product_Id = orderItem.ProductId,
                    Quantity = orderItem.Quantity,
                    Price = orderItem.TotalPrice,
                    Order_Note = orderItem.OrderNote
                };
                orderingService.AddToCart(newOrderItems);
            }
        }

        private void CashPaymentButton_Click(object sender, EventArgs e)
        {
            CreateOrder("Cash Payment");
            string receiptContent = GenerateReceiptContent(OrderItems, "Cash Payment");
            PrintReceipt(receiptContent);
            RestartApplication();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PaymentMethodBackButton?.Invoke();
            HideOrderList();
        }
    }
}
