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
    public partial class UpdatePasswordUserControl : UserControl
    {
        public event Action BackToSettingsEventHandler;

        public UpdatePasswordUserControl()
        {
            InitializeComponent();
        }

        private void UpdateAccount_Click(object sender, EventArgs e)
        {
            BackToSettingsEventHandler?.Invoke();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackToSettingsEventHandler?.Invoke();
        }
    }
}
