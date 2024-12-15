using System;
using System.Windows.Forms;

namespace Orange_POS.Views.AdminViews.AdminViewUserControlContents
{
    public partial class OrderDetailsUserControl : UserControl
    {
        public OrderDetailsUserControl(string orderType)
        {
            InitializeComponent();
            this.Order_Type = orderType;
        }
        public string Order_Number
        {
            get => OrderNumber.Text;
            set => OrderNumber.Text = value;
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

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Print logic here
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            // Complete order logic here
        }
    }
}
