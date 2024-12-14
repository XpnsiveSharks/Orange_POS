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
    public partial class SettingsUserControl : UserControl
    {
        public event Action CreateAccountEventHandler;
        public event Action ChangePasswordEventHandler;
        public event Action DeleteAccountEventHandler;

        public string username { get; set; }
        public SettingsUserControl()
        {
            InitializeComponent();
            username = CurrentUsernameSettings.Text;
            CurrentUsernameSettings.Text = CurrentUser.Username ?? "Not Logged In";
        }

           public void UpdateLoggedInUser()
        {
            CurrentUsernameSettings.Text = CurrentUser.Username ?? "Not Logged In";
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
        }
    }
}
