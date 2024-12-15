using Orange_POS.Models;
using Orange_POS.Repositories;
using Orange_POS.Views.AdminViews.AdminViewUserControlContents;
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

                Console.WriteLine($"Number of pending orders retrieved: {pendingOrders.Count}");

                OrdersFlowLayoutPanel.Controls.Clear();

                foreach (var order in pendingOrders)
                {
                    Console.WriteLine($"Adding Order Number: {order.Order_Number}");

                    OrderDetailsUserControl orderDetailsUserControl = new OrderDetailsUserControl(order.Order_Type)
                    {
                        Order_Number = order.Order_Number,
                        Order_Date = order.Order_Date,
                        Order_Type = order.Order_Type
                    };

                    OrdersFlowLayoutPanel.Controls.Add(orderDetailsUserControl);
                }

                Console.WriteLine($"Number of controls added to OrdersFlowLayoutPanel: {OrdersFlowLayoutPanel.Controls.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while loading pending orders: " + ex.Message);
            }
        }
    }
}
