using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.SharedViews
{
    public partial class MainLoginView : Form
    {

        public MainLoginView()
        {
            InitializeComponent();
        }
        private void ShowLoginUserControl(UserControl userControl)
        {
            foreach (Control control in LoginPanel.Controls)
            {
                control.Visible = false;
            }
            userControl.Dock = DockStyle.Fill;
            LoginPanel.Controls.Add(userControl);
        }

        public void RemoveLoginUserControl(UserControl userControl)
        {
            LoginPanel.Controls.Remove(userControl);

            foreach (Control control in LoginPanel.Controls)
            {
                control.Visible = true;
            }
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            ShowLoginUserControl(new SharedViewsUserControl.AdminLoginUserControl("Admin"));
        }

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            ShowLoginUserControl(new SharedViewsUserControl.StaffLoginUserControl("Staff"));
        }
    }
}
