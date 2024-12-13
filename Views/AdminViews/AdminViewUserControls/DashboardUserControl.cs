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
            var orders = _ordersViewModel.LoadOrders(startDate, endDate);

            ReportsDataGridView.AutoGenerateColumns = false;
            ReportsDataGridView.Columns.Clear();

            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderNumber",
                HeaderText = "Order No."
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderDate",
                HeaderText = "Date"
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderType",
                HeaderText = "Type"
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Amount"
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product"
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Quantity"
            });

            ReportsDataGridView.DataSource = orders;
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            // Get the selected date range
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Reload data with filters
            LoadData(startDate, endDate);
        }
        private void FilterButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
