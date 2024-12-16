using Orange_POS.Helpers;
using Orange_POS.Views.AdminViews;
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
    public partial class AdminLoginUserControl : UserControl
    {
        private readonly AdminIndexView adminIndexView = new AdminIndexView();

        public string UserRole { get; set; }
        ValidateCredentials validateCreds = new ValidateCredentials();

        public AdminLoginUserControl(string userRole)
        {
            InitializeComponent();
            UserRole = userRole;
        }


        public class CurrentUser
        {
            public static string Username { get; set; }
            public static string UserRole { get; set; }
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            if (this.Parent is Panel panel && panel.FindForm() is MainLoginView mainLogin)
            {
                mainLogin.RemoveLoginUserControl(this);
            }
        }

        private void AdminLoginButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = AdminUsernameTextBox.Text;
                string password = AdminPasswordTextBox.Text;
                string confirmPassword = ConfirmPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                
                if (password != confirmPassword)
                {
                    MessageBox.Show("New password and confirmation password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (validateCreds.validateCredentials(username, password, "admin"))
                {
                    CurrentUser.UserRole = "admin";
                    CurrentUser.Username = username;
                    adminIndexView.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username and password", "Error");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("An error has occurred while accessing the database", ex);
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                AdminPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                AdminPasswordTextBox.PasswordChar = '●';
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
    }
}
