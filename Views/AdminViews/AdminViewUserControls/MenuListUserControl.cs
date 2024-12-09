using Orange_POS.ViewModels;
using Orange_POS.Views.AdminViews.AdminViewUserControlContents;
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
    public partial class MenuListUserControl : UserControl
    {
        private ProductViewModel _productViewModel;
        public event Action InsertMenuEventHandler;
        public MenuListUserControl()
        {
            _productViewModel = new ProductViewModel();
            InitializeComponent();
            LoadMenus();
        }
        public void LoadMenus()
        {
            _productViewModel.LoadProductsToUserControl();
            UpdateProductPanel();
        }
        public void ReloadMenus()
        {
            _productViewModel.LoadProducts();
            LoadMenus();
        }
        private void UpdateProductPanel()
        {
            MenuListFlowLayoutPanel.Controls.Clear();
            foreach (var control in _productViewModel.ProductControls)
            {
                MenuListFlowLayoutPanel.Controls.Add(control);
            }
        }

        private void AddMenuButton_Click(object sender, EventArgs e)
        {
            InsertMenuEventHandler?.Invoke();
        }

        private void EditMenuButton_Click(object sender, EventArgs e)
        {

        }
    }
}
