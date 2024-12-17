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
    public partial class OrderTypeView : Form
    {
        private OrderTypeUserControl orderTypeUserControl = new OrderTypeUserControl();
        public OrderTypeView()
        {
            InitializeComponent();
            LoadUserControl(orderTypeUserControl);
            LoadOrderTypeUserControl();
        }
        private void LoadOrderTypeUserControl()
        {
            LoadUserControl(orderTypeUserControl);
        }
        private void LoadUserControl(UserControl userControl)
        {
            OrderTypePanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            OrderTypePanel.Controls.Add(userControl);
            OrderTypePanel.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
