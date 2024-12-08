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

namespace Orange_POS.Views.AdminViews
{
    public partial class AdminIndexView : Form
    {
        private CreateAccountUserControl _createAccountUserControl;
        private DeleteAccountUserControl _deleteAccountUserControl;
        private InsertProductUserControl _insertProductUserControl;
        private MenuListUserControl _productListUserControl;
        private SettingsUserControl _settingsUserControl;
        private UpdatePasswordUserControl _updatePasswordUserControl;
        public AdminIndexView()
        {
            InitializeComponent();
            InitializeInstances();
        }
        private void InitializeInstances() 
        {
            _createAccountUserControl = new CreateAccountUserControl();
            _deleteAccountUserControl = new DeleteAccountUserControl();
            _insertProductUserControl = new InsertProductUserControl();
            _productListUserControl = new MenuListUserControl();
            _settingsUserControl = new SettingsUserControl();
            _updatePasswordUserControl = new UpdatePasswordUserControl();
        }
        private void DashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(_productListUserControl);
        }

        private void OrderListButton_Click(object sender, EventArgs e)
        {
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(_settingsUserControl);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }
        private void LoadUserControl(UserControl userControl)
        {
            AdminIndexPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            AdminIndexPanel.Controls.Add(userControl);
        }
    }
}
