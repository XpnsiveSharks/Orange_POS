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
            set => NamePendingOrder.Text = value; 
        }
        public int QuantityOrder 
        { 
            get => int.TryParse(QuantityPendingOrder.Text, out var price) ? price : 0;
            set => QuantityPendingOrder.Text = value.ToString();
        }
    }
}
