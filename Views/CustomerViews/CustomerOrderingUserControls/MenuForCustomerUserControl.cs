using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.CustomerViews.CustomerOrderingUserControls
{
    public partial class MenuForCustomerUserControl : UserControl
    {
        public event EventHandler<(string ProductName, double ProductPrice, int ProductId)> ProductClicked;
        public event Action MenuUserControlItemCount;
        public MenuForCustomerUserControl()
        {
            InitializeComponent();
            AttachClickEvents();
            PanelConfiguration();
            ProductNameLabel.Size = new Size(170, 30);
        }
        private void PanelConfiguration()
        {
            ProductPanel.BorderColor = ColorTranslator.FromHtml("#e9dfce");
            ProductPanel.BorderRadius = 20;
            ProductPanel.MouseHover += ProductPanel_MouseHover;
            ProductPanel.MouseEnter += ProductPanel_MouseEnter;
            ProductPanel.MouseLeave += ProductPanel_MouseLeave;
        }
        public int ProductId { get; set; }
        public int itemsCount { get; set; }
        public Image ProductImage
        {
            get => ProductButton.Image;
            set => ProductButton.Image = value;
        }
        private string _productName;
        public string ProductNames
        {
            get => ProductNameLabel.Text;
            set
            {
                _productName = value;
                ProductNameLabel.Text = value;
                SetProductNameLabel(ProductNameLabel, value, ProductPanel);
            }
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
            ProductClicked?.Invoke(this, (ProductNames, ProductPrice, ProductId));
            MenuUserControlItemCount?.Invoke();
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

        private void AdjustFontSize(Guna.UI2.WinForms.Guna2HtmlLabel label, string text, Guna.UI2.WinForms.Guna2GradientPanel panel)
        {
            using (Graphics g = label.CreateGraphics())
            {
                float fontSize = label.Font.Size;
                SizeF textSize = g.MeasureString(text, label.Font);
                while (textSize.Width > panel.Width && label.Font.Size > 1)
                {
                    fontSize -= 0.5f;
                    label.Font = new Font(label.Font.FontFamily, fontSize, label.Font.Style);
                    textSize = g.MeasureString(text, label.Font);
                }
            }
        }
        private void SetProductNameLabel(Guna.UI2.WinForms.Guna2HtmlLabel label, string text, Guna.UI2.WinForms.Guna2GradientPanel panel)
        {
            label.Text = text;
            AdjustFontSize(label, text, ProductPanel);
        }

    }
}
