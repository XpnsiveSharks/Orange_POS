using Orange_POS.Helpers;
using Orange_POS.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    public partial class SettingsUserControl : UserControl
    {
        public event Action CreateAccountEventHandler;
        public event Action ChangePasswordEventHandler;
        public event Action DeleteAccountEventHandler;
        public event Action EditAccountEventHandler;
        private readonly MainLoginView mainLoginView = new MainLoginView();
        private readonly DeleteAccountUserControl deleteAccountView = new DeleteAccountUserControl();
        private readonly EditAccountUserControl editAccountView = new EditAccountUserControl();
        
        public SettingsUserControl()
        {
            InitializeComponent();
            editAccountView.SetUserDetails();
        }

        public void UpdateLoggedInUser()
        {

            Fullname.Text = $"{GetUser.FirstName} {GetUser.MiddleName} {GetUser.LastName}" ?? "Not Logged In";
            CurrentUsernameSettings.Text = GetUser.Username ?? "Not Logged In";
            Role.Text = GetUser.User_Role ?? "Not Logged In";
            Email.Text = GetUser.Email ?? "Not Logged In";
            ContactNumber.Text = GetUser.ContactNumber ?? "Not Logged In";

        }
        private void CreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountEventHandler?.Invoke();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordEventHandler?.Invoke();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccountEventHandler?.Invoke();
            deleteAccountView.LoadUsersIntoGridView();

        }

     
        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                mainLoginView.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }

       
      
        private void EditAccount_Click(object sender, EventArgs e)
        {
            EditAccountEventHandler?.Invoke();
            editAccountView.SetUserDetails();
            
        }
    }
}
