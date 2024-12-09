using Orange_POS.Configurations;
using Orange_POS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Orange_POS.Repositories
{
    internal class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public OrderDetailsRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public List<OrderDetails> GetOrderDetails()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = @"
                SELECT 
                    orders_table.Order_number AS OrderNumber, 
                    orders_table.Order_Date AS OrderDate, 
                    orders_table.Order_Type AS OrderType, 
                    orders_table.Total_Amount AS TotalAmount, 
                    orders_table.Payment_Method AS PaymentMethod, 
                    products_table.product_name AS ProductName, 
                    order_items_table.Quantity AS Quantity
                FROM order_items_table 
                LEFT JOIN orders_table ON order_items_table.orders_id = orders_table.order_id 
                LEFT JOIN products_table ON order_items_table.product_id = products_table.product_id";

                    return connection.Query<OrderDetails>(query).ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while accessing the database.", ex);
            }
        }
    }
}
