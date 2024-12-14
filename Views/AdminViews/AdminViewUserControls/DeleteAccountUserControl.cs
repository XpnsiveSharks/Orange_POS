using Orange_POS.Helpers;
using Orange_POS.Repositories;
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
using static Orange_POS.Views.SharedViews.SharedViewsUserControl.AdminLoginUserControl;

namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    public partial class DeleteAccountUserControl : UserControl
    {
        public event Action BackToSettingsEventHandler;
        private readonly UsersRepository usersRepository = new UsersRepository();
        private readonly MainLoginView mainLoginView = new MainLoginView();

        public DeleteAccountUserControl()
        {
            InitializeComponent();
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            BackToSettingsEventHandler?.Invoke();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            string username = DeleteUsername.Text;
            string password = DeletePassword.Text;
            string confirmPassword = ConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Username and Password are required to delete an account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                $"Are you sure you want to delete the account for '{username}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (password != confirmPassword)
            {
                MessageBox.Show("Password Doesnt match try again!", "Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = usersRepository.DeleteUser(username, password);

                    if (isDeleted)
                    {
                        MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        if (username == CurrentUser.Username)
                        {
                            CurrentUser.Username = null;
                            CurrentUser.UserRole = null;
                            mainLoginView.Show();
                        }
                        else
                        {
                            DeleteUsername.Clear();
                            DeletePassword.Clear();
                            ConfirmPassword.Clear();
                            BackToSettingsEventHandler?.Invoke();
                        }
                     
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                DeletePassword.PasswordChar = '\0';
            }
            else
            {
                DeletePassword.PasswordChar = '●';
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
