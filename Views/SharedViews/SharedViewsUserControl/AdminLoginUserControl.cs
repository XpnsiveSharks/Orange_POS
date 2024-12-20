using Orange_POS.Configurations;
using Orange_POS.Helpers;
using Orange_POS.Models;
using Orange_POS.Repositories;
using Orange_POS.Views.AdminViews;
using Orange_POS.Views.AdminViews.AdminViewUserControls;
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
        UsersRepository UsersRepository = new UsersRepository();
        ValidateCredentials validateCreds = new ValidateCredentials();

        public AdminLoginUserControl(string userRole)
        {
            InitializeComponent();
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

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                     MessageBox.Show("Username and Password cannot be empty.");
                     return;
                }

                Users user = UsersRepository.getCredentials(username,password, "Admin");

                if (validateCreds.validateCredentials(username, password, "Admin"))
                {
                  
                       
                    if (user == null)
                    {
                          MessageBox.Show("Invalid username, password, or role. Please try again.");
                          return;
                    }

                    GetUser.Username = user.Username; 
                    GetUser.User_Role = user.User_Role;
                    GetUser.FirstName = user.FirstName;
                    GetUser.MiddleName = user.Middlename;
                    GetUser.LastName = user.LastName;
                    GetUser.ContactNumber = user.Contactnumber;
                    GetUser.Email = user.Email;

                    this.Hide();
                    adminIndexView.Show();

                }


                else if (!validateCreds.validateCredentials(username, password, "admin"))
                {
                    MessageBox.Show("User is Not Existing!");

                }

               

            }
            catch (Exception ex)
            {
                throw new Exception("An error has occurred while accessing the database", ex);
            }



        }

     
        private void ShowPassword__Click(object sender, EventArgs e)
        {
            if (AdminPasswordTextBox.PasswordChar == '●')
            {
                HidePassword_.BringToFront();
                AdminPasswordTextBox.PasswordChar = '\0';
            }
        }

        private void HidePassword__Click(object sender, EventArgs e)
        {
            if (AdminPasswordTextBox.PasswordChar == '\0')
            {
                ShowPassword_.BringToFront();
                AdminPasswordTextBox.PasswordChar = '●';
            }
        }
    }
}
