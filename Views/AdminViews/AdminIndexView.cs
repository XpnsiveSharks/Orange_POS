using Orange_POS.Helpers;
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
        private Dictionary<AdminViewControl, UserControl> _controls;
        public AdminIndexView()
        {
            InitializeComponent();
            InitializeControls();
            ChangeUserControl();
            LoadUserControl(AdminViewControl.Dashboard);
        }
        private void InitializeControls()
        {
            _controls = new Dictionary<AdminViewControl, UserControl>
            {
                { AdminViewControl.MenutList, new MenuListUserControl() },
                { AdminViewControl.Settings, new SettingsUserControl() },
                { AdminViewControl.CreateAccount, new CreateAccountUserControl() },
                { AdminViewControl.UpdatePassword, new UpdatePasswordUserControl() },
                { AdminViewControl.DeleteAccount, new DeleteAccountUserControl() },
                { AdminViewControl.InsertProduct, new InsertProductUserControl() },
                { AdminViewControl.Dashboard, new DashboardUserControl() },
                { AdminViewControl.OrderList, new OrderListUserControl() }
            };
        }

        private void LoadUserControl(AdminViewControl controlKey)
        {
            if (!_controls.ContainsKey(controlKey))
                return;

            AdminIndexPanel.Controls.Clear();
            var userControl = _controls[controlKey];
            userControl.Dock = DockStyle.Fill;
            AdminIndexPanel.Controls.Add(userControl);
        }
        private void ChangeUserControl()
        {
            var eventSubscriptions = new Dictionary<AdminViewControl, Action<UserControl>>
            {
                { AdminViewControl.Settings, SubscribeSettingsEvents },
                { AdminViewControl.CreateAccount, SubscribeCreateAccountEvents },
                { AdminViewControl.UpdatePassword, SubscribeUpdatePasswordEvents },
                { AdminViewControl.MenutList, SubscribeMenuListUserEvents },
                { AdminViewControl.InsertProduct, SubscribeInsertProductUserEvents },
                { AdminViewControl.Dashboard, SubscribeDashboardUserEvents },
                { AdminViewControl.OrderList, SubscribeOrderListUserEvents }

            };

            foreach (var controlKey in _controls.Keys)
            {
                if (eventSubscriptions.TryGetValue(controlKey, out var subscriptionAction) &&
                    _controls.TryGetValue(controlKey, out var userControl))
                {
                    subscriptionAction(userControl);
                }
            }
        }
        private void SubscribeInsertProductUserEvents(UserControl control)
        {
            if (control is InsertProductUserControl insertProductUserControl)
            {
                insertProductUserControl.BackToMenuListEventHandler -= OnMenuReload;
                insertProductUserControl.BackToMenuListEventHandler += OnMenuReload;
            }
        }
        private void SubscribeUpdatePasswordEvents(UserControl control)
        {
            if (control is UpdatePasswordUserControl updatePasswordControl)
            {
                updatePasswordControl.BackToSettingsEventHandler -= OnBackToSettings;
                updatePasswordControl.BackToSettingsEventHandler += OnBackToSettings;
            }
        }
        
        private void SubscribeMenuListUserEvents(UserControl control)
        {
            if (control is MenuListUserControl menuListUserControl)
            {
                menuListUserControl.InsertMenuEventHandler -= OnInsertMenu;
                menuListUserControl.InsertMenuEventHandler += OnInsertMenu;

                menuListUserControl.UpdateMenuEventHandler -= OnUpdateMenu;
                menuListUserControl.UpdateMenuEventHandler += OnUpdateMenu;
            }
        }
        private void SubscribeCreateAccountEvents(UserControl control)
        {
            if (control is CreateAccountUserControl createAccountControl)
            {
                createAccountControl.BackToSettingsEventHandler -= OnBackToSettings;
                createAccountControl.BackToSettingsEventHandler += OnBackToSettings;
            }
        }
        private void SubscribeDashboardUserEvents(UserControl control)
        {
            if (control is DashboardUserControl dashboardUserControl)
            {
                dashboardUserControl.BackToDashboardEventHandler -= OnDashboardReload;
                dashboardUserControl.BackToDashboardEventHandler += OnDashboardReload;
            }
        }
        private void SubscribeOrderListUserEvents(UserControl control)
        {
            if (control is OrderListUserControl orderListUserControl)
            {
                orderListUserControl.BackToOrderListEventHandler -= OnOrderListReload;
                orderListUserControl.BackToOrderListEventHandler += OnOrderListReload;
            }
        }
        private void SubscribeSettingsEvents(UserControl control)
        {
            if (control is SettingsUserControl settingsControl)
            {
                settingsControl.CreateAccountEventHandler -= OnCreateAccount; 
                settingsControl.CreateAccountEventHandler += OnCreateAccount;

                settingsControl.ChangePasswordEventHandler -= OnChangePasswordAccount;
                settingsControl.ChangePasswordEventHandler += OnChangePasswordAccount;

                settingsControl.DeleteAccountEventHandler -= OnDeleteAccount;
                settingsControl.DeleteAccountEventHandler += OnDeleteAccount;

            }
        }
        private void OnMenuReload()
        {
            if (_controls.TryGetValue(AdminViewControl.MenutList, out var control) && control is MenuListUserControl menuListUserControl)
            {
                menuListUserControl.ReloadMenus();
                LoadUserControl(AdminViewControl.MenutList);
            }
        }
        private void OnUpdateMenu(int productId)
        {
            if (_controls.TryGetValue(AdminViewControl.InsertProduct, out var control) &&
                control is InsertProductUserControl insertProductUserControl)
            {
                insertProductUserControl.ProductId = productId;
                insertProductUserControl.IsUpdate = true;
                insertProductUserControl.InitializeControl(); 
                LoadUserControl(AdminViewControl.InsertProduct);
            }
        }

        private void OnInsertMenu()
        {
            LoadUserControl(AdminViewControl.InsertProduct);
        }
        private void OnBackToSettings()
        {
            LoadUserControl(AdminViewControl.Settings);
        }
        private void OnDeleteAccount()
        {
            LoadUserControl(AdminViewControl.DeleteAccount);
        }
        private void OnCreateAccount()
        {
            LoadUserControl(AdminViewControl.CreateAccount);
        }
        private void OnChangePasswordAccount()
        {
            LoadUserControl(AdminViewControl.UpdatePassword);
        }
        private void OnDashboardReload()
        {         
            LoadUserControl(AdminViewControl.Dashboard);          
        }
        private void OnOrderListReload()
        {
            LoadUserControl(AdminViewControl.OrderList);
        }
        private void DashboardButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(AdminViewControl.Dashboard);
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(AdminViewControl.MenutList);
        }

        private void OrderListButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(AdminViewControl.OrderList);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(AdminViewControl.Settings);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
