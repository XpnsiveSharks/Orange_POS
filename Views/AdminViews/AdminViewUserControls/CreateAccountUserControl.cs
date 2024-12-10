using Orange_POS.Helpers;
using Orange_POS.Models;
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
        public CreateAccountUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackToSettingsEventHandler?.Invoke();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {

            string username = CreateUsername.Text;
            string password = CreatePassword.Text;
            string user_role = CreateUserRole.Text;

            PasswordHashing passwordHashing = new PasswordHashing();

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                string hashedpassword = passwordHashing.hashPassword(password);
                passwordHashing.SaveToDatabase(username, hashedpassword, user_role);
                MessageBox.Show("Account Has Been Created");
                CreateUsername.Clear();
                CreatePassword.Clear();

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
    }
}
