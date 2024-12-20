using Orange_POS.Helpers;
using Orange_POS.Models;
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

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                if (validateCreds.validateCredentials(username, password, "Staff"))
                {

                    GetUser.User_Role = "Staff";
                    GetUser.Username = username;
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
                if (validateCreds.validateCredentials(username, password, "Staff"))
                {

                    GetUser.User_Role = "Staff";
                    GetUser.Username = username;
                    StaffIndexView.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username and password", "Error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        private void ShowPassword__Click(object sender, EventArgs e)
        {
            if (StaffPasswordTextBox.PasswordChar== '●')
            {
                HidePassword_.BringToFront();
                StaffPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void HidePassword__Click(object sender, EventArgs e)
        {
            if (StaffPasswordTextBox.PasswordChar == '\0')
            {
                ShowPassword_.BringToFront();
                StaffPasswordTextBox.PasswordChar = '●';
            }
        }
    }
}
