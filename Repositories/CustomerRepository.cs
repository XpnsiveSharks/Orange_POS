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
    internal class CustomerRepository : ICustomerRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public CustomerRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public void AddCustomer(Customer customer)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO Customer_table (Created_At, Customer_Number) VALUES (@Created_At, @Customer_Number)";
                    connection.Execute(insertQuery, new
                    {
                        Created_At = customer.Created_At,
                        Customer_Number = customer.Customer_Number
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public int GetCustomerIdByCustomerNumber(string customerNumber)
        {

            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT Customer_Id FROM customer_table WHERE Customer_Number = @Customer_Number";
                    return connection.QuerySingleOrDefault<int>(query, new { Customer_Number = customerNumber });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public string GetCustomerNumber()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT Customer_Number FROM customer_table WHERE Customer_Id = (SELECT MAX(Customer_Id) FROM customer_table)";
                    string customerNumber = connection.QuerySingleOrDefault<string>(query);
                    return customerNumber ?? "C00000";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
