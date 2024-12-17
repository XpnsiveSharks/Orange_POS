using Orange_POS.Helpers;
using Orange_POS.Models;
using Orange_POS.Repositories;
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
    public partial class UpdatePasswordUserControl : UserControl
    {
        public event Action BackToSettingsEventHandler;
        private readonly UsersRepository usersRepository = new UsersRepository();
        private readonly Users users = new Users();
        InputValidation inputValidation = new InputValidation();

        public UpdatePasswordUserControl()
        {
            InitializeComponent();
        }

        private void UpdateAccount_Click(object sender, EventArgs e)
        {

            string currentPassword = CurrentPassword.Text;
            string newPassword = NewPassword.Text;
            string confirmPassword = ConfirmPassword.Text;

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!inputValidation.ValidatePassword(newPassword))
            {
                MessageBox.Show("Password must be at least 8 characters long, include an uppercase letter, number, and special character.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isUpdated = usersRepository.UpdateUsers(currentPassword, newPassword);

            if (isUpdated)
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentPassword.Clear();
                NewPassword.Clear();
                ConfirmPassword.Clear();
               
            }
            else
            {
                MessageBox.Show("Invalid current password. Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BackToSettingsEventHandler?.Invoke();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackToSettingsEventHandler?.Invoke();
            CurrentPassword.Clear();
            NewPassword.Clear();
            ConfirmPassword.Clear();
           
        }

       /* private void ShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowNewPassword.Checked)
            {
                NewPassword.PasswordChar = '\0';
            }
            else
            {
                NewPassword.PasswordChar = '●';
            }
        }*/

       /* private void ShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowConfirmPassword.Checked)
            {
                ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                ConfirmPassword.PasswordChar = '●';
            }
        }*/

        private void ShowNewPassword__Click(object sender, EventArgs e)
        {
            if (NewPassword.PasswordChar == '●')
            {
                HideNewPassword_.BringToFront();
                NewPassword.PasswordChar = '\0';
            }
        }

        private void HideNewPassword__Click(object sender, EventArgs e)
        {
            if (NewPassword.PasswordChar == '\0')
            {
                ShowNewPassword_.BringToFront();
                NewPassword.PasswordChar = '●';
            }
        }

        private void ShowConfirmPassword__Click(object sender, EventArgs e)
        {
            if (ConfirmPassword.PasswordChar == '●')
            {
                HideConfirmPassword_.BringToFront();
                ConfirmPassword.PasswordChar = '\0';
            }
        }

        private void HideConfirmPassword__Click(object sender, EventArgs e)
        {
            if (ConfirmPassword.PasswordChar == '\0')
            {
                ShowConfirmPassword_.BringToFront();
                ConfirmPassword.PasswordChar = '●';
            }
        }
    }
}
