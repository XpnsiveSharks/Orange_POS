using Orange_POS.Models;
using Orange_POS.Repositories;
using Orange_POS.Views.AdminViews.AdminViewUserControlContents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.ViewModels
{
    internal class ProductViewModel : INotifyPropertyChanged
    {
        private readonly ProductRepository _productRepository;
        public event PropertyChangedEventHandler PropertyChanged;
        public ProductViewModel()
        {
            _productRepository = new ProductRepository();
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private List<Products> _products;
        public List<Products> Products
        {
            get => _products;
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }
        private string _menu;
        public string Menu
        {
            get => _menu;
            set
            {
                _menu = value;
                OnPropertyChanged(nameof(Menu));
            }
        }
        private string _productName;
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }
        private double _productPrice;
        public double ProductPrice
        {
            get => _productPrice;
            set
            {
                _productPrice = value;
                OnPropertyChanged(nameof(ProductPrice));
            }
        }
        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        private string _productImageFilePath;
        public string ProductImageFilePath
        {
            get => _productImageFilePath;
            set
            {
                _productImageFilePath = value;
                OnPropertyChanged(nameof(ProductImageFilePath));
                OnPropertyChanged(nameof(SelectedProductImage));
            }
        }
        public Image SelectedProductImage =>
             !string.IsNullOrEmpty(_productImageFilePath) ? Image.FromFile(_productImageFilePath) : null;
        /// <summary>
        /// Adding menu
        /// </summary>
        public void AddingMenu()
        {
            var newProduct = new Products
            {
                Menu = _menu,
                Product_Name = _productName,
                Product_Price = _productPrice,
                Product_Image_File_Path = _productImageFilePath
            };
            _productRepository.AddProduct(newProduct);
        }
        public void UpdateProduct(int product)
        {
            var updatedProduct = new Products
            {
                Product_Id = product,
                Menu = this._menu,
                Product_Name = this._productName,
                Product_Price = this._productPrice,
                Product_Image_File_Path = this._productImageFilePath
            };
            _productRepository.UpdateProduct(updatedProduct);
        }
        public Products GetProductById(int productId)
        {
            return _productRepository.GetProductById(productId);
        }
        public void DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }

        private List<MenuUserControl> _productControls;
        public List<MenuUserControl> ProductControls
        {
            get => _productControls;
            set
            {
                if (_productControls != value)
                {
                    _productControls = value;
                    OnPropertyChanged(nameof(ProductControls));
                }
            }
        }
        public void LoadProductsToUserControl()
        {
            List<MenuUserControl> productDisplayUserControls = new List<MenuUserControl>();
            foreach (var item in _productRepository.GetAllProducts())
            {
                MenuUserControl productDisplayUserControl = new MenuUserControl
                {
                    ProductId = item.Product_Id,
                    ProductNames = item.Product_Name,
                    ProductPrice = item.Product_Price,
                    MenuCategory = item.Menu
                };
                string imagePath = Path.Combine(Application.StartupPath, "Resources", item.Product_Image_File_Path);
                string fallbackImagePath = Path.Combine(Application.StartupPath, "Resources", "D:\\Repositories\\bin\\Debug\\no_image.jpg");
                productDisplayUserControl.ProductImage = File.Exists(imagePath)
                    ? Image.FromFile(imagePath)
                    : Image.FromFile(fallbackImagePath);
                productDisplayUserControls.Add(productDisplayUserControl);
            }
            ProductControls = productDisplayUserControls;
        }
        public void LoadProducts()
        {
            Products = _productRepository.GetAllProducts() ?? new List<Products>();
        }
    }
}
