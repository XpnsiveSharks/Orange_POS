using Orange_POS.Models;
using Orange_POS.Repositories;
using Orange_POS.Views.AdminViews.AdminViewUserControlContents;
using Orange_POS.Views.StaffViews.StaffUserControls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Orange_POS.Views.StaffViews
{
    public partial class StaffIndexView : Form
    {
        private OrdersRepository ordersRepository;
        private Label PendingOrdersCountLabel;
        public int Order_Count 
        {
            get => int.TryParse(OrderCount.Text, out var count) ? count : 0;
            set => OrderCount.Text = $"Pending orders: {value}";
        }
        public StaffIndexView()
        {
            InitializeComponent();
            ordersRepository = new OrdersRepository();
            LoadPendingOrders();
        }

        private void LoadPendingOrders()
        {
            try
            {
                List<Orders> pendingOrders = ordersRepository.GetPendingOrders();
                OrdersFlowLayoutPanel.Controls.Clear();

                foreach (var order in pendingOrders)
                {
                    var orderDetailsUserControl = new DetailsUserControl()
                    {
                        Order_Number = order.Order_Number,
                        Order_Date = order.Order_Date,
                        Order_Type = order.Order_Type
                    };
                    orderDetailsUserControl.OrderCompleted += OnOrderCompleted;
                    OrdersFlowLayoutPanel.Controls.Add(orderDetailsUserControl);
                }
                Order_Count = pendingOrders.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while loading pending orders: " + ex.Message);
            }
        }
        private void OnOrderCompleted(object sender, EventArgs e)
        {
            Order_Count--;
            LoadPendingOrders();
        }
    }
}
