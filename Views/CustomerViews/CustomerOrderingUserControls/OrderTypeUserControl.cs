using Orange_POS.Views.SharedViews;
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
    public partial class OrderTypeUserControl : UserControl
    {
        private CustomerIndexView customerIndexView;
        public OrderTypeUserControl()
        {
            InitializeComponent();
        }

        private void DineInButton_Click(object sender, EventArgs e)
        {
            customerIndexView = new CustomerIndexView
            {
                OrderType = "Dine In"
            };
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
            customerIndexView.Show();
        }

        private void TakeOutButton_Click(object sender, EventArgs e)
        {
            customerIndexView = new CustomerIndexView
            {
                OrderType = "Take Out"
            };
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
            customerIndexView.Show();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit?", "Exit program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainLoginView mainLoginView = new MainLoginView();

                mainLoginView.Show();
                var parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Hide();
                }
                
            }
            else
            {
                return;
            }
        }

    }
}
