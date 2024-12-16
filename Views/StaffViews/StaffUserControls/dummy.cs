using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.StaffViews.StaffUserControls
{
    public partial class dummy : UserControl
    {
        public dummy()
        {
            InitializeComponent();
        }
        public string MyProperty 
        { 
            set => dummylabel.Text = value; 
        }
    }
}
