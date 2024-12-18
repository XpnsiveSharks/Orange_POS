using Orange_POS.Views.CustomerViews.CustomerOrderingUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.CustomerViews
{
    public partial class OrderListView : Form
    {
        private PaymentMethodView paymentMethodView = new PaymentMethodView();
        private OrdersUserControl ordersUserControl = new OrdersUserControl();
        public string OrderType { get; set; }
        public event Action PaymentButtonClicked;
        public List<OrdersUserControl> OrderItems { get; set; } = new List<OrdersUserControl>();
        public event Action OrderListBackButton;
        public event Action<int> OrderListItemCount;

        public int ItemCount { get; set; }
        public double SubTotal
        {
            get => double.TryParse(TotalLabel.Text, out var price) ? price : 0;
            set => TotalLabel.Text = $"Total : {value.ToString("F2")}";
        }

        public OrderListView(string orderType)
        {
            InitializeComponent();
            OrderType = orderType;
        }

        private void HideOrderList()
        {
            this.Hide();
        }

        public void ShowOrderListView()
        {
            if (ItemCount != 0)
            {
                DisplayOrderItems();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please add an item");
            }
        }

        public void DisplayOrderItems()
        {
            orderListFlowLayoutPanel.Controls.Clear();

            foreach (var orderItem in OrderItems)
            {
                orderListFlowLayoutPanel.Controls.Add(orderItem);
                orderItem.ItemRemovedFromOrderList -= OnItemRemoved;
                orderItem.ItemRemovedFromOrderList += OnItemRemoved;
                orderItem.QuantityChanged -= OnQuantityChanged;
                orderItem.QuantityChanged += OnQuantityChanged;
            }

            ItemCount = OrderItems.Count;

            UpdateSubTotal();
        }

        private void OnItemRemoved(object sender, EventArgs e)
        {
            if (sender is OrdersUserControl orderItem)
            {
                orderListFlowLayoutPanel.Controls.Remove(orderItem);
                OrderItems.Remove(orderItem);

                orderItem.ItemRemovedFromOrderList -= OnItemRemoved;
                orderItem.Dispose();

                ItemCount--;
                OrderListItemCount?.Invoke(ItemCount);

                UpdateSubTotal();

                if (orderListFlowLayoutPanel.Controls.Count == 0)
                {
                    this.Hide();
                }
            }
        }

        public string GetUniqueOrderType()
        {
            return OrderItems.Select(orderItem => orderItem.OrderType).Distinct().FirstOrDefault();
        }

        private void OnQuantityChanged(object sender, EventArgs e)
        {
            UpdateSubTotal();
        }
        private void UpdateSubTotal()
        {
            double subtotal = 0;
            foreach (OrdersUserControl item in orderListFlowLayoutPanel.Controls)
            {
                subtotal += item.TotalPrice;
            }
            SubTotal = subtotal;

            if (orderListFlowLayoutPanel.Controls.Count == 0)
            {
                SubTotal = 0;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OrderListBackButton?.Invoke();
            OrderListItemCount?.Invoke(ItemCount);
            HideOrderList();
        }

        private void ProceedToPaymentButton_Click(object sender, EventArgs e)
        {
            string orderType = GetUniqueOrderType();
            var paymentMethodView = new PaymentMethodView
            {
                OrderType = orderType,
                OrderItems = this.OrderItems
            };
            paymentMethodView.OrderListViewReference = this;
            paymentMethodView.Show();
            HideOrderList();
        }
    }
}
