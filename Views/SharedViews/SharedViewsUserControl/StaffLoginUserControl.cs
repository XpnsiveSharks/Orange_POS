using Orange_POS.Helpers;
using Orange_POS.Views.AdminViews;
using Orange_POS.Views.StaffViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Orange_POS.Views.SharedViews.SharedViewsUserControl.AdminLoginUserControl;

namespace Orange_POS.Views.SharedViews.SharedViewsUserControl
{
    public partial class StaffLoginUserControl : UserControl
    {
        public string UserRole { get; set; }
        ValidateCredentials validateCreds = new ValidateCredentials();
        StaffIndexView StaffIndexView = new StaffIndexView();
        public StaffLoginUserControl(string userRole)
        {
            InitializeComponent();
            UserRole = userRole;
        }
        private void StaffLoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                string username = StaffUsernameTextBox.Text;
                string password = StaffPasswordTextBox.Text;
                string confirmPassword = ConfirmPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                if (validateCreds.validateCredentials(username, password, "Staff"))
                {

                    CurrentUser.UserRole = "Staff";
                    CurrentUser.Username = username;
                    StaffIndexView.Show();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            if (this.Parent is Panel panel && panel.FindForm() is MainLoginView mainLogin)
            {
                mainLogin.RemoveLoginUserControl(this);
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                StaffPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                StaffPasswordTextBox.PasswordChar = '●';
            }
        }

        private void ShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (ShowConfirmPassword.Checked)
            {
                ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                ConfirmPassword.PasswordChar = '●';
            }
        }

        private void StaffLoginButton_Click_2(object sender, EventArgs e)
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
                string confirmPassword = ConfirmPassword.Text;
                if (password != confirmPassword)
                {
                    MessageBox.Show("New password and confirmation password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (validateCreds.validateCredentials(username, password, "Staff"))
                {

                    CurrentUser.UserRole = "Staff";
                    CurrentUser.Username = username;
                    StaffIndexView.Show();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
