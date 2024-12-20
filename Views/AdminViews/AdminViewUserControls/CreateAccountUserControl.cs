using Mysqlx.Crud;
using Orange_POS.Helpers;
using Orange_POS.Models;
using Orange_POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    public partial class CreateAccountUserControl : UserControl
    {
        public event Action BackToSettingsEventHandler;
        private readonly Users users = new Users();
        InputValidation inputValidation = new InputValidation();
        private readonly DeleteAccountUserControl deleteAccountUserControl = new DeleteAccountUserControl();

        public CreateAccountUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackToSettingsEventHandler?.Invoke();
            CreateUsername.Clear();
            CreatePassword.Clear();
            ConfirmPassword.Clear();
    
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {

            string username = CreateUsername.Text;
            string password = CreatePassword.Text.Trim();
            string user_role = CreateUserRole.Text;
            string confirm_password = ConfirmPassword.Text.Trim();
            string firstname = FirstName.Text;
            string lastname = LastName.Text;
            string middlename = MiddleName.Text;
            string contactnumber = ContactNumber.Text;
            string email = Email.Text;


            PasswordHashing passwordHashing = new PasswordHashing();

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm_password)) 
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }

                if (CreateUserRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select option from the dropdown.");
                    return;
                }

                if (password != confirm_password)
                {
                    MessageBox.Show("Password Doesnt match try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!inputValidation.ValidatePassword(password))
                {
                    MessageBox.Show("Password must be at least 8 characters long, include an uppercase letter, number, and special character.","Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!inputValidation.ValidateUsername(username))
                {
                    MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                   
                }

                string hashedpassword = passwordHashing.hashPassword(password);

                passwordHashing.SaveToDatabase(username, hashedpassword, user_role, firstname, lastname, middlename, contactnumber, email);

                MessageBox.Show("Account Has Been Created");

               

                CreateUsername.Clear();
                CreatePassword.Clear();
                ConfirmPassword.Clear();
                FirstName.Clear(); 
                LastName.Clear();
                MiddleName.Clear();
                ContactNumber.Clear();
                Email.Clear();
              
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
            BackToSettingsEventHandler?.Invoke();
        }


        private void ShowPassword__Click(object sender, EventArgs e)
        {
            if (CreatePassword.PasswordChar == '●')
            {
                HidePassword_.BringToFront();
                CreatePassword.PasswordChar = '\0';
            }
        }

        private void HidePassword__Click(object sender, EventArgs e)
        {
            if (CreatePassword.PasswordChar == '\0')
            {
                ShowPassword_.BringToFront();
                CreatePassword.PasswordChar = '●';
            }

        }

     

        private void ShowConfirmPassword__Click_1(object sender, EventArgs e)
        {
            if (ConfirmPassword.PasswordChar == '●')
            {
                HideConfirmPassword_.BringToFront();
                ConfirmPassword.PasswordChar = '\0';
            }
        }

        private void HideConfirmPassword__Click_1(object sender, EventArgs e)
        {
            if (ConfirmPassword.PasswordChar == '\0')
            {
                ShowConfirmPassword_.BringToFront();
                ConfirmPassword.PasswordChar = '●';
            }
        }
    }
}
