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
    internal class OrdersRepository : IOrdersRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;

        public OrdersRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }

        public void AddOrders(Orders orders)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO Orders_table (Order_Number, Order_Date, Order_Type, Customer_Id, Total_Amount, Status, Payment_Method) VALUES (@Order_Number, @Order_Date, @Order_Type, @Customer_Id, @Total_Amount, @Status, @Payment_Method)";
                    connection.Execute(insertQuery, new
                    {
                        Order_Number = orders.Order_Number,
                        Order_Date = orders.Order_Date,
                        Order_Type = orders.Order_Type,
                        Customer_Id = orders.Customer_Id,
                        Total_Amount = orders.Total_Amount,
                        Status = orders.Status,
                        Payment_Method = orders.Payment_Method
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public int GetOrderIdByOrderNumber(string orderNumber)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT Order_Id FROM orders_table WHERE Order_Number = @Order_Number";
                    return connection.QuerySingleOrDefault<int>(query, new { Order_Number = orderNumber });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public string GetOrderNumber()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT Order_Number FROM orders_table WHERE Order_Id = (SELECT MAX(Order_Id) FROM orders_table)";
                    string ordernumber = connection.QuerySingleOrDefault<string>(query);
                    return ordernumber ?? "B00000";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public List<Orders> GetPendingOrders()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT * FROM orders_table WHERE Status = @Status";
                    return connection.Query<Orders>(query, new { Status = "Pending" }).ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public void UpdateOrderStatus(string orderNumber, string newStatus)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var updateQuery = "UPDATE orders_table SET Status = @Status WHERE Order_Number = @Order_Number";
                    connection.Execute(updateQuery, new { Status = newStatus, Order_Number = orderNumber });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occurred while updating the order status", ex);
            }
        }

        public List<ProductOrderInfo> GetProductOrderInfo(string orderNumber)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = @"
                SELECT 
                    oi.Quantity,
                    p.Product_Name,
                    oi.Order_Note
                FROM 
                    Order_Items_Table oi
                JOIN 
                    Products_Table p ON oi.Product_Id = p.Product_Id
                JOIN 
                    Orders_Table o ON oi.Order_Id = o.Order_Id
                WHERE 
                    oi.Quantity IS NOT NULL AND o.Order_Number = @Order_Number";

                    return connection.Query<ProductOrderInfo>(query, new { Order_Number = orderNumber }).ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occurred while accessing the database", ex);
            }
        }


    }
}
