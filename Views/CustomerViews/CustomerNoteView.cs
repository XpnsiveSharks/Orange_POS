using Orange_POS.Views.CustomerViews.CustomerOrderingUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Views.CustomerViews
{
    public partial class CustomerNoteView : Form
    {
        private OrdersUserControl ordersUserControl;
        public CustomerNoteView(OrdersUserControl ordersUserControl, string orderNote)
        {
            InitializeComponent();
            this.ordersUserControl = ordersUserControl;
            this.OrderNote = orderNote;
        }
        public string OrderNote 
        { 
            get => OrderNote; 
            set => NoteTextBox.Text = value; 
        }
        private void SubmitNoteButton_Click(object sender, EventArgs e)
        {
            if(ordersUserControl != null)
            {
                ordersUserControl.OrderNote = NoteTextBox.Text;
                Console.WriteLine("Test for note view " + ordersUserControl.OrderNote);
            }
            this.Hide();
        }
    }
}
