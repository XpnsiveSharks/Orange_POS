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
    public partial class ItemUserControl : UserControl
    {
        public event EventHandler RemoveItemClicked;
        private OrderListView orderListView;

        public ItemUserControl(OrderListView orderListView)
        {
            InitializeComponent();
            this.orderListView = orderListView;
        }

        public string OrderType { get; set; }
        public int ProductId { get; set; }
        public double ProductPrice { get; set; }

        public string OrderName
        {
            get => OrderNameLabel.Text;
            set => OrderNameLabel.Text = value;
        }

        public double OrderPrice
        {
            get => double.TryParse(ItemPriceLabel.Text, out var price) ? price : 0;
            set => ItemPriceLabel.Text = value.ToString("F2");
        }

        public int Quantity
        {
            get => int.TryParse(QuantityTextBox.Text, out var quantity) ? quantity : 0;
            set => QuantityTextBox.Text = value.ToString();
        }

        public string ItemCount
        {
            get => ItemCountLabel.Text;
            set => ItemCountLabel.Text = value;
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            ClearOrderSelection();
        }

        public void ClearOrderSelection()
        {
            OrderNameLabel.Text = "";
            ItemPriceLabel.Text = "";
            QuantityTextBox.Text = "";
            QuantityTextBox.Text = "";
            DecreaseOrderButton.Visible = false;
            IncreaseOrderButton.Visible = false;
            QuantityTextBox.Visible = false;
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OrderName))
            {
                MessageBox.Show("Please add an item");
                return;
            }

            var existingItem = orderListView.OrderItems.FirstOrDefault(item => item.ProductId == ProductId);

            if (existingItem != null)
            {
                MessageBox.Show("Item is already in the list");
            }
            else
            {
                var orderListItem = new OrdersUserControl
                {
                    Product = OrderName,
                    Quantity = Quantity,
                    TotalPrice = OrderPrice,
                    QuantityOnTextBox = Quantity,
                    OrderPrice = ProductPrice,
                    OrderType = this.OrderType,
                    ProductId = this.ProductId,
                };

                orderListView.OrderItems.Add(orderListItem);

                orderListView.DisplayOrderItems();
                orderListView.ShowOrderListView();

                orderListView.OrderListBackButton += ClearOrderSelection;
                orderListView.OrderListItemCount += (itemCount) =>
                {
                    ItemCount = (itemCount == 1) ? $"{itemCount} item in the list" : $"{itemCount} items in the list";
                };
            }
        }

        private void DecreaseOrderButton_Click(object sender, EventArgs e)
        {
            if (Quantity > 0)
            {
                Quantity--;
                if (Quantity == 0)
                {
                    RemoveItemClicked?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    OrderPrice = Quantity * (OrderPrice / (Quantity + 1));
                }
            }
        }

        private void IncreaseOrderButton_Click(object sender, EventArgs e)
        {
            Quantity++;
            OrderPrice = Quantity * (OrderPrice / (Quantity - 1));
        }

        private void ViewOrdersButton_Click(object sender, EventArgs e)
        {
            orderListView.ShowOrderListView();
        }

      
 
    }
}
