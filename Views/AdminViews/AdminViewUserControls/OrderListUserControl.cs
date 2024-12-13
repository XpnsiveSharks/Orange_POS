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
    public partial class OrderListUserControl : UserControl
    {
        public event Action BackToOrderListEventHandler;
        public OrderListUserControl()
        {
            InitializeComponent();
        }
    }
}
