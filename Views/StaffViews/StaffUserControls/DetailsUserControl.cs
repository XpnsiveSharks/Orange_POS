using Orange_POS.Models;
using Orange_POS.Repositories;
using Orange_POS.Views.AdminViews.AdminViewUserControlContents;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Orange_POS.Views.StaffViews.StaffUserControls
{
    public partial class DetailsUserControl : UserControl
    {
        private OrdersRepository ordersRepository;
        public event EventHandler OrderCompleted;
        public DetailsUserControl()
        {
            InitializeComponent();
            ordersRepository = new OrdersRepository();
        }

        public string Order_Number
        {
            get => OrderNumber.Text;
            set
            {
                OrderNumber.Text = value;
                LoadProductOrderInfo();
            }
        }

        public string Order_Date
        {
            get => OrderDate.Text;
            set => OrderDate.Text = value;
        }

        public string Order_Type
        {
            get => OrderType.Text;
            set => OrderType.Text = value;
        }

        private void LoadProductOrderInfo()
        {
            try
            {
                List<ProductOrderInfo> productOrderInfos = ordersRepository.GetProductOrderInfo(Order_Number);

                PendingOrderFlowLayout.Controls.Clear();

                foreach (var productInfo in productOrderInfos)
                {
                    PendingOrderUserControl pendingOrderUserControl = new PendingOrderUserControl
                    {
                        PendingOrder = productInfo.Product_Name,
                        QuantityOrder = productInfo.Quantity,
                        OrderNote = productInfo.Order_Note
                    };

                    PendingOrderFlowLayout.Controls.Add(pendingOrderUserControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while loading product order information: " + ex.Message);
            }
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                ordersRepository.UpdateOrderStatus(Order_Number, "Completed");

                if (this.Parent is FlowLayoutPanel flowLayoutPanel)
                {
                    flowLayoutPanel.Controls.Remove(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while updating the order status: " + ex.Message);
            }

            OrderCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

        }

    }
}
