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
    public partial class PendingOrderUserControl : UserControl
    {
        public PendingOrderUserControl()
        {
            InitializeComponent();
        }
        public string PendingOrder 
        { 
            get => NamePendingOrder.Text;
            set 
            { 
                NamePendingOrder.Text = value;
                SetProductNameLabel(NamePendingOrder, value, PendingOrderPanel);
            }
        }
        public int QuantityOrder 
        { 
            get => int.TryParse(QuantityPendingOrder.Text, out var price) ? price : 0;
            set => QuantityPendingOrder.Text = $"-- {value.ToString()}";
        }
        public string OrderNote 
        { 
            get => OrderNoteLabel.Text; 
            set => OrderNoteLabel.Text = value; 
        }

        private void AdjustFontSize(Guna.UI2.WinForms.Guna2HtmlLabel label, string text, Guna.UI2.WinForms.Guna2Panel panel)
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
        private void SetProductNameLabel(Guna.UI2.WinForms.Guna2HtmlLabel label, string text, Guna.UI2.WinForms.Guna2Panel panel)
        {
            label.Text = text;
            AdjustFontSize(label, text, PendingOrderPanel);
        }
    }
}
