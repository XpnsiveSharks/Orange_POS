using Orange_POS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private string _printContent;
        private int hoveredRowIndex = -1;
        public DashboardUserControl()
        {
            InitializeComponent();
            _ordersViewModel = new OrdersViewModel();
            LoadData();
            ReportsDataGridView.CellDoubleClick += ReportsDataGridView_CellDoubleClick;
            ReportsDataGridView.CellMouseEnter += ReportsDataGridView_CellMouseEnter;
            ReportsDataGridView.CellMouseLeave += ReportsDataGridView_CellMouseLeave;
        }

        private void LoadData(string startDate = null, string endDate = null)
        {
            var orders = _ordersViewModel.LoadOrders(startDate, endDate);

            ReportsDataGridView.AutoGenerateColumns = false;
            ReportsDataGridView.Columns.Clear();

            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderNumber",
                DataPropertyName = "OrderNumber",
                HeaderText = "Order No."
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderDate",
                DataPropertyName = "OrderDate",
                HeaderText = "Date"
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderType",
                DataPropertyName = "OrderType",
                HeaderText = "Type"
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                DataPropertyName = "TotalAmount",
                HeaderText = "Amount"
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                DataPropertyName = "ProductName",
                HeaderText = "Product"
            });
            ReportsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                DataPropertyName = "Quantity",
                HeaderText = "Quantity"
            });

            ReportsDataGridView.DataSource = orders;
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            LoadData(startDate, endDate);
        }

        private void ReportsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ReportsDataGridView.Rows.Count)
            {
                var selectedRow = ReportsDataGridView.Rows[e.RowIndex];
                var orderDetails = new
                {
                    OrderNumber = selectedRow.Cells["OrderNumber"].Value?.ToString(),
                    OrderDate = selectedRow.Cells["OrderDate"].Value?.ToString(),
                    OrderType = selectedRow.Cells["OrderType"].Value?.ToString(),
                    TotalAmount = selectedRow.Cells["TotalAmount"].Value?.ToString(),
                    ProductName = selectedRow.Cells["ProductName"].Value?.ToString(),
                    Quantity = selectedRow.Cells["Quantity"].Value?.ToString()
                };

                _printContent = GeneratePrintableContent(orderDetails);

                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintDocument_PrintPage;
                printPreviewDialog.Document = printDocument;

                DialogResult result = printPreviewDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }

        private string GeneratePrintableContent(dynamic orderDetails)
        {
            return $"Order Details\n" +
                   $"---------------------------\n" +
                   $"Order Number: {orderDetails.OrderNumber}\n" +
                   $"Order Date: {orderDetails.OrderDate}\n" +
                   $"Order Type: {orderDetails.OrderType}\n" +
                   $"Total Amount: {orderDetails.TotalAmount}\n" +
                   $"Product Name: {orderDetails.ProductName}\n" +
                   $"Quantity: {orderDetails.Quantity}\n" +
                   $"---------------------------";
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = 25;
            float y = 20;
            float lineHeight = 30;
            using (Font font = new Font("Century Gothic", 18))
            {
                foreach (string line in _printContent.Split('\n'))
                {
                    e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                    y += lineHeight;
                }
            }
        }

        private void ReportsDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                hoveredRowIndex = e.RowIndex;
                ReportsDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e9dfce"); 
            }
        }

        private void ReportsDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex == hoveredRowIndex)
            {
                ReportsDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#fffdfb");
                hoveredRowIndex = -1; 
            }
        }
    }
}
