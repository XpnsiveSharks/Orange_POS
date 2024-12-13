using Mysqlx.Crud;
using Orange_POS.Helpers;
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
using Guna.UI2.WinForms;

namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    public partial class InsertProductUserControl : UserControl
    {
        private readonly ProductViewModel productViewModel = new ProductViewModel();
        InputValidation inputValidation = new InputValidation();    
        public event Action BackToMenuListEventHandler;
        public int ProductId { get; set; }
        public bool IsUpdate;
        public InsertProductUserControl()
        {
            InitializeComponent();
            InitializeDataBindings();
            IsProductUpdating();
            PopulateComboBoxItems();
            ProductPriceTextBox.KeyPress += ProductPriceTextBox_KeyPress;
            ProductPriceTextBox.TextChanged += ProductPriceTextBox_TextChanged;
        }
        private void InitializeDataBindings()
        {
            ProductPreviewPictureBox.DataBindings.Add("Image", productViewModel, nameof(productViewModel.SelectedProductImage), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductNameTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.ProductName), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductPriceTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.ProductPrice), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductMenuComboBox.DataBindings.Add("SelectedItem", productViewModel, nameof(productViewModel.Menu), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void PopulateComboBoxItems()
        {
            ProductMenuComboBox.Items.Clear();
            ProductMenuComboBox.Items.AddRange(new[] { "Ulam", "Drinks", "Desserts" });
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
            string price = ProductPriceTextBox.Text.Trim();
            if (!inputValidation.ValidatePrice(price))
            {
                MessageBox.Show("Invalid Price.Please enter valid number greater than 0.");
                return;
            }
            if (ProductMenuComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select option from the dropdown.");
                return;
            }            
            if (string.IsNullOrWhiteSpace(productViewModel.ProductName))
            {
                MessageBox.Show("Please enter product name.");
                return;
            }  
            if (!inputValidation.ValidateProductName(productViewModel.ProductName))
            {
                MessageBox.Show("A product with this name already exists. Please choose another name.");
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
                ClearComponents();
            }           
            BackToMenuListEventHandler?.Invoke();            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearComponents();
            BackToMenuListEventHandler?.Invoke();
        }

        private void ProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
                           
            if (e.KeyChar == '.' && ProductPriceTextBox.Text.Contains("."))
            {
                e.Handled = true;
            }           
        }

        private void ProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text.Count(c => c == '.') > 1)
                {
                    int lastIndex = textBox.Text.LastIndexOf(".");
                    textBox.Text = textBox.Text.Remove(lastIndex, 1);
                    textBox.SelectionStart = textBox.Text.Length;
                }

                if (!decimal.TryParse(textBox.Text, out _))
                {
                    textBox.Text = "";
                }
            }
        }
        public void ClearComponents()
        {
            ProductNameTextBox.Text = string.Empty;
            ProductPriceTextBox.Text = string.Empty;
            ProductMenuComboBox.SelectedIndex = -1;
            ProductPreviewPictureBox.Image = null;
        }
        public void ClearComponents()
        {
            ProductNameTextBox.Text = string.Empty;
            ProductPriceTextBox.Text = string.Empty;
            ProductMenuComboBox.SelectedIndex = -1;
            ProductPreviewPictureBox.Image = null;
        }
    }
}
