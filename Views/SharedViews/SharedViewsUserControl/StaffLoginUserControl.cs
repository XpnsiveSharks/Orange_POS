using Orange_POS.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.SharedViews.SharedViewsUserControl
{
    public partial class StaffLoginUserControl : UserControl
    {
        public string UserRole { get; set; }
        ValidateCredentials validateCreds = new ValidateCredentials();
        public StaffLoginUserControl(string userRole)
        {
            InitializeComponent();
            UserRole = userRole;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel panel && panel.FindForm() is MainLoginView mainLogin)
            {
                mainLogin.RemoveLoginUserControl(this);
            }
        }

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                string username = StaffUsernameTextBox.Text;
                string password = StaffPasswordTextBox.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                if (validateCreds.validateCredentials(username, password, UserRole))
                {
                    //CustomerMainFrameView customerMainFrameView = new CustomerMainFrameView();
                    //customerMainFrameView.Show();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
