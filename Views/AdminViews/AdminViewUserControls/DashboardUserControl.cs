using Orange_POS.ViewModels;
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
    public partial class DashboardUserControl : UserControl
    {
        public event Action BackToDashboardEventHandler;
        private OrdersViewModel _ordersViewModel;
        public DashboardUserControl()
        {
            InitializeComponent();
            _ordersViewModel = new OrdersViewModel();
            LoadData();
        }

        private void LoadData(string startDate = null, string endDate = null)
        {
            // Load orders using the ViewModel
            var orders = _ordersViewModel.LoadOrders(startDate, endDate);

            // Bind the data to the DataGridView
            ReportsDataGridView.AutoGenerateColumns = true;
            ReportsDataGridView.DataSource = orders;
            CustomizeDataGridViewHeaders();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            // Get the selected date range
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Reload data with filters
            LoadData(startDate, endDate);
        }

        private void CustomizeDataGridViewHeaders()
        {
            if (ReportsDataGridView.Columns.Contains("Order_Number"))
            {
                ReportsDataGridView.Columns["Order_Number"].HeaderText = "Order No.";
            }
            if (ReportsDataGridView.Columns.Contains("Order_Date"))
            {
                ReportsDataGridView.Columns["Order_Date"].HeaderText = "Date";
            }
            if (ReportsDataGridView.Columns.Contains("Product_Name"))
            {
                ReportsDataGridView.Columns["Product_Name"].HeaderText = "Product";
            }
            if (ReportsDataGridView.Columns.Contains("Total_Amount"))
            {
                ReportsDataGridView.Columns["Total_Amount"].HeaderText = "Amount";
            }
            if (ReportsDataGridView.Columns.Contains("Quantity"))
            {
                ReportsDataGridView.Columns["Quantity"].HeaderText = "Quantity";
            }
        }
        
    }
}
