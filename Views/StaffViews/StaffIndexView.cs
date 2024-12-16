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


                    OrdersFlowLayoutPanel.Controls.Add(orderDetailsUserControl);
                    /*var dummyUsercontrol = new dummy()
                    {
                        MyProperty = order.Order_Type
                    };
*/

                    //OrdersFlowLayoutPanel.Controls.Add(dummyUsercontrol);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while loading pending orders: " + ex.Message);
            }
        }
    }
}
