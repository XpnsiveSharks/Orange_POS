using Orange_POS.ViewModels;
using Orange_POS.Views.CustomerViews.CustomerOrderingUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.CustomerViews
{
    public partial class CustomerIndexView : Form
    {
        private readonly CustomerViewModel _customerViewModel;
        private readonly OrderListView orderListView;
        public string OrderType { get; set; }
        public string ItemCount { get; set; }
        public CustomerIndexView()
        {
            InitializeComponent();
            _customerViewModel = new CustomerViewModel();
            orderListView = new OrderListView(OrderType);
            LoadMenus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainCourseButton_Click(object sender, EventArgs e)
        {
            FilterProducts("Main Course");
        }

        private void SnacksButton_Click(object sender, EventArgs e)
        {
            FilterProducts("Snacks");
        }

        private void DessertsButton_Click(object sender, EventArgs e)
        {
            FilterProducts("Desserts");
        }

        private void BeveragesButton_Click(object sender, EventArgs e)
        {
            FilterProducts("Beverages");
        }

        private void ShowAllProductsButton_Click(object sender, EventArgs e)
        {
            UpdateProductPanel();
        }

        public void LoadMenus()
        {
            _customerViewModel.LoadProductsToUserControl();
            UpdateProductPanel();
        }
        public void ReloadMenus()
        {
            _customerViewModel.LoadProducts();
            LoadMenus();
        }

        private void FilterProducts(string productMenu)
        {
            string searchQuery = productMenu.Trim().ToLower();

            if (string.IsNullOrEmpty(searchQuery))
            {
                UpdateProductPanel();
                return;
            }

            var filteredControls = _customerViewModel.ProductControls
                .Where(control => control.MenuCategory.ToLower().Contains(searchQuery))
                .ToList();

            UpdateFlowLayoutPanel(MenuFLowLayoutPanel, filteredControls);
        }

        private void UpdateProductPanel()
        {
            UpdateFlowLayoutPanel(MenuFLowLayoutPanel, _customerViewModel.ProductControls);
        }

        private void UpdateFlowLayoutPanel(FlowLayoutPanel panel, IEnumerable<Control> controls)
        {
            panel.SuspendLayout();
            panel.Controls.Clear();

            foreach (var control in controls)
            {
                if (control is MenuForCustomerUserControl menuControl)
                {
                    menuControl.ProductClicked -= OnProductClicked;
                    menuControl.ProductClicked += OnProductClicked;
                }
                panel.Controls.Add(control);
            }

            panel.ResumeLayout();
        }
        private void UpdateItemCount()
        {
            orderListView.OrderListItemCount += (itemCount) =>
            {
                ItemCount = (itemCount == 1) ? $"{itemCount} item in the list" : $"{itemCount} items in the list";
            };
        }
        private void OnProductClicked(object sender, (string ProductName, double ProductPrice, int ProductId) e)
        {
            var (productName, productPrice, productId) = e;
            ShowCart(productName, productPrice, productId);
        }

        public void ShowCart(string productName, double productPrice, int productId)
        {
            var itemControl = GetOrCreateItemControl(productName, productPrice, orderListView, productId);
            itemControl.Quantity++;
            itemControl.OrderPrice = itemControl.Quantity * productPrice;
        }

        private ItemUserControl GetOrCreateItemControl(string productName, double productPrice, OrderListView orderListView, int productId)
        {
            ItemModificationPanel.Controls.Clear();
            UpdateItemCount();
            var newItemControl = new ItemUserControl(orderListView)
            {
                Dock = DockStyle.Top,
                OrderName = productName,
                OrderPrice = productPrice,
                ProductPrice = productPrice,
                Quantity = 0,
                ItemCount = this.ItemCount,
                ProductId = productId,
                OrderType = this.OrderType
            };

            newItemControl.RemoveItemClicked += OnItemRemoved;
            ItemModificationPanel.Controls.Add(newItemControl);

            return newItemControl;
        }
        private void OnItemRemoved(object sender, EventArgs e)
        {
            if (sender is ItemUserControl itemUserControl)
            {
                ItemModificationPanel.Controls.Remove(itemUserControl);
                itemUserControl.Dispose();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit?",
              "Exit Program",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }

        }
    }
}
