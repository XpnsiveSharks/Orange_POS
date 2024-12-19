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
            ShowPassword.Checked = false;
            ShowConfirmPassword.Checked = false;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {

            string username = CreateUsername.Text;
            string password = CreatePassword.Text.Trim();
            string user_role = CreateUserRole.Text;
            string confirm_password = ConfirmPassword.Text.Trim();

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
                passwordHashing.SaveToDatabase(username, hashedpassword, user_role);
                MessageBox.Show("Account Has Been Created");
                CreateUsername.Clear();
                CreatePassword.Clear();
                ConfirmPassword.Clear();
                ShowPassword.Checked = false;
                ShowConfirmPassword.Checked = false;
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
            BackToSettingsEventHandler?.Invoke();
         
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                CreatePassword.PasswordChar = '\0';
            }
            else
            {
                CreatePassword.PasswordChar = '●';
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
