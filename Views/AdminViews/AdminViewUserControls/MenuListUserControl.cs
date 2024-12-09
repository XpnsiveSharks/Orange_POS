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
       
        public MenuListUserControl()
        {
            _productViewModel = new ProductViewModel();
            InitializeComponent();
            ReloadProducts();
        }
        private void ReloadProducts()
        {
            _productViewModel.LoadProductsToUserControl();
            UpdateProductPanel();
        }
        private void UpdateProductPanel()
        {
            MenuListFlowLayoutPanel.Controls.Clear();
            foreach (var control in _productViewModel.ProductControls)
            {
                MenuListFlowLayoutPanel.Controls.Add(control);
            }
        }

        private void MenuListUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
