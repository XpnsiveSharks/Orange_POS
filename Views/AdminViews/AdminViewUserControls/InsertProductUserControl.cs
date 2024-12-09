using Mysqlx.Crud;
using Orange_POS.Models;
using Orange_POS.ViewModels;
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
    public partial class InsertProductUserControl : UserControl
    {
        private readonly ProductViewModel productViewModel = new ProductViewModel();
        public event Action BackToMenuListEventHandler;
        public int ProductId { get; set; }
        public bool IsUpdate;
        public InsertProductUserControl()
        {
            InitializeComponent();
            InitializeDataBindings();
            IsProductUpdating();
        }
        private void InitializeDataBindings()
        {
            ProductPreviewPictureBox.DataBindings.Add("Image", productViewModel, nameof(productViewModel.SelectedProductImage), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductNameTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.ProductName), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductPriceTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.ProductPrice), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductMenuComboBox.DataBindings.Add("SelectedItem", productViewModel, nameof(productViewModel.Menu), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        public void InitializeControl()
        {
            if (IsUpdate)
            {
                DisplaySelectedProduct();
            }
            else
            {
                ResetForm();
            }
        }
        private void ResetForm()
        {
            productViewModel.ProductName = string.Empty;
            productViewModel.ProductPrice = 0;
            productViewModel.Description = string.Empty;
            productViewModel.ProductImageFilePath = string.Empty;
            productViewModel.Menu = string.Empty;
        }
        private void IsProductUpdating()
        {
            IsUpdate = ProductId != 0;
            if (IsUpdate)
                DisplaySelectedProduct();
        }
        private void DisplaySelectedProduct()
        {
            var product = productViewModel.GetProductById(ProductId);
            if (product == null)
            {
                MessageBox.Show("Product not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productViewModel.Menu = product.Menu;
            productViewModel.ProductName = product.Product_Name;
            productViewModel.ProductPrice = product.Product_Price;
            productViewModel.ProductImageFilePath = product.Product_Image_File_Path;
        }
        private void ProductImageUploadButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    productViewModel.ProductImageFilePath = openFileDialog.FileName;
                    MessageBox.Show("File Selected!");
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productViewModel.ProductName))
            {
                MessageBox.Show("Please enter product name.");
                return;
            }
            if (string.IsNullOrEmpty(productViewModel.ProductImageFilePath))
            {
                MessageBox.Show("Please upload an Image.");
                return;
            }
            if (IsUpdate)
            {
                productViewModel.UpdateProduct(ProductId);
                MessageBox.Show("Product updated successfully");
            }
            else
            {
                productViewModel.AddingMenu();
                MessageBox.Show("Product saved successfully");
            }
            BackToMenuListEventHandler?.Invoke();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BackToMenuListEventHandler?.Invoke();
        }
    }
}
