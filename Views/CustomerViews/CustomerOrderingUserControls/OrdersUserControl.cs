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
    public partial class OrdersUserControl : UserControl
    {
        public event EventHandler ItemRemovedFromOrderList;
        public event EventHandler QuantityChanged;

        public OrdersUserControl()
        {
            InitializeComponent();
        }
        public int ProductId { get; set; }
        public string OrderType { get; set; }
        public string Product
        {
            get => OrderNameLabel.Text;
            set => OrderNameLabel.Text = value;
        }
        public int Quantity
        {
            get => int.TryParse(OrderQuantityLabel.Text, out var quantity) ? quantity : 0;
            set => OrderQuantityLabel.Text = value.ToString();
        }
        public double TotalPrice
        {
            get => double.TryParse(OrderTotalLabel.Text, out var price) ? price : 0;
            set => OrderTotalLabel.Text = value.ToString("F2");
        }

        public int QuantityOnTextBox
        {
            get => int.TryParse(QuantityTextBox.Text, out var quantity) ? quantity : 0;
            set => QuantityTextBox.Text = value.ToString();
        }
        public double OrderPrice
        {
            get => double.TryParse(OrderPriceLabel.Text, out var price) ? price : 0;
            set => OrderPriceLabel.Text = value.ToString("F2");
        }
        public string OrderNote 
        {
            get;
            set;
        }
        private void RemoveOrderButton_Click(object sender, EventArgs e)
        {
            ItemRemovedFromOrderList?.Invoke(this, EventArgs.Empty);

        }
        private void DecreaseOrderButton_Click(object sender, EventArgs e)
        {
            if (QuantityOnTextBox > 1)
            {
                QuantityOnTextBox--;
                Quantity = QuantityOnTextBox;
                TotalPrice = Quantity * (TotalPrice / (Quantity + 1));
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                ItemRemovedFromOrderList?.Invoke(this, EventArgs.Empty);
            }
        }
        private void IncreaseOrderButton_Click(object sender, EventArgs e)
        {
            QuantityOnTextBox++;
            Quantity = QuantityOnTextBox;
            TotalPrice = Quantity * (TotalPrice / (Quantity - 1));
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AddNoteForCustomerOrderButton_Click(object sender, EventArgs e)
        {
            var customerNotesView = new CustomerNoteView(this, this.OrderNote);
            customerNotesView.Show();
        }
    }
}
