using Orange_POS.Models;
using Orange_POS.Repositories;
using Orange_POS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.CustomerViews.CustomerOrderingUserControls
{
    public partial class PaymentMethodUserControl : UserControl
    {
        private readonly OrderingService orderingService = new OrderingService();
        private readonly CustomerRepository customerRepository = new CustomerRepository();
        private readonly OrdersRepository ordersRepository = new OrdersRepository();

        private string customerNumber;
        private string orderNumber;
        private string dateAndTime;
        public PaymentMethodUserControl()
        {
            InitializeComponent();
        }
        public List<OrdersUserControl> OrderItems { get; set; }

        public string OrderType { get; set; }

        private void CashPaymentButton_Click(object sender, EventArgs e)
        {
            CreateOrder("Cash Payment");
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                    Price = orderItem.TotalPrice
                };
                orderingService.AddToCart(newOrderItems);
            }
        }

    }
}
