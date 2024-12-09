using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.AdminViews.AdminViewUserControlContents
{
    public partial class MenuUserControl : UserControl
    {
        public event EventHandler<int> ProductClicked;
        public MenuUserControl()
        {
            InitializeComponent();
            AttachClickEvents();

            //panel configuration
            ProductPanel.BorderColor = ColorTranslator.FromHtml("#e9dfce");
            ProductPanel.BorderRadius = 20;
            ProductPanel.MouseHover += ProductPanel_MouseHover;
            ProductPanel.MouseEnter += ProductPanel_MouseEnter; 
            ProductPanel.MouseLeave += ProductPanel_MouseLeave;
        }
        public int ProductId { get; set; }
        public Image ProductImage
        {
            get => ProductButton.Image;
            set => ProductButton.Image = value;
        }
        public string ProductNames
        {
            get => ProductNameLabel.Text;
            set => ProductNameLabel.Text = value;
        }
        public double ProductPrice
        {
            get => double.TryParse(PriceLabel.Text, out var price) ? price : 0;
            set => PriceLabel.Text = value.ToString("F2");
        }
        public string MenuCategory
        {
            get => MenuCategoryLabel.Text;
            set => MenuCategoryLabel.Text = value;
        }
        private void AttachClickEvents()
        {
            ProductButton.Click += NotifyProductClicked;
            ProductNameLabel.Click += NotifyProductClicked;
            PriceLabel.Click += NotifyProductClicked;
            ProductPanel.Click += NotifyProductClicked;
            MenuCategoryLabel.Click += NotifyProductClicked;
        }
        private void NotifyProductClicked(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this,(ProductId));
        }



        private void ProductPanel_MouseHover(object sender, EventArgs e)
        {
            ProductPanel.BorderColor = ColorTranslator.FromHtml("#d45c2f");
            ProductPanel.BorderRadius = 20;
        }

        private void ProductPanel_MouseEnter(object sender, EventArgs e)
        {
            ProductPanel.BorderColor = ColorTranslator.FromHtml("#d45c2f");
            ProductPanel.BorderRadius = 20;
        }

        private void ProductPanel_MouseLeave(object sender, EventArgs e)
        {
            ProductPanel.BorderColor = ColorTranslator.FromHtml("#e9dfce");
            ProductPanel.BorderRadius = 20;
        }
    }
}
