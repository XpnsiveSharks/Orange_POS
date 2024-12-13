using Orange_POS.Models;
using Orange_POS.ViewModels;
using Orange_POS.Views.AdminViews.AdminViewUserControlContents;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    public partial class MenuListUserControl : UserControl
    {
        InsertProductUserControl insertProductUserControl = new InsertProductUserControl();
        private ProductViewModel _productViewModel;
        public event Action InsertMenuEventHandler;
        public event Action<int> DeleteMenuEventHandler;
        public event Action<int> UpdateMenuEventHandler;


        public MenuListUserControl()
        {
            _productViewModel = new ProductViewModel();
            InitializeComponent();
            guna2ContextMenuStrip1.ItemClicked += guna2ContextMenuStrip1_ItemClicked;
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
                if (control is MenuUserControl menuControl)
                {
                    menuControl.ContextMenuStrip = guna2ContextMenuStrip1;
                    menuControl.ProductClicked += MenuControl_ProductClicked;
                    menuControl.Tag = menuControl.ProductId;
                }

                MenuListFlowLayoutPanel.Controls.Add(control);
            }
        }

        private void MenuControl_ProductClicked(object sender, int productId)
        {
            if (sender is MenuUserControl menuControl)
            {
                guna2ContextMenuStrip1.Tag = productId; 
                guna2ContextMenuStrip1.Show(Cursor.Position); 
            }
        }

        private void AddMenuButton_Click(object sender, EventArgs e)
        {        
            InsertMenuEventHandler?.Invoke();
        }

        private void guna2ContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "UpdateToolStripMenuItem")
            {
                UpdateToolStripMenuItem_Click(sender, e);
            }
            else if (e.ClickedItem.Name == "DeleteToolStripMenuItem")
            {
                DeleteToolStripMenuItem_Click(sender, e);
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guna2ContextMenuStrip1.Tag is int productId)
            {
                UpdateMenuEventHandler?.Invoke(productId);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (guna2ContextMenuStrip1.Tag is int productId)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    _productViewModel.DeleteProduct(productId);
                    ReloadMenus();
                    MessageBox.Show($"Product has been deleted.",
                        "Delete Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        
    }

}
