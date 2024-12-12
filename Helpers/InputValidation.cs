using Dapper;
using Orange_POS.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS.Helpers
{
    internal class InputValidation
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public InputValidation()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }

        public bool ValidateUsername(string username)
        {
            if (username.Length < 7)
            {
                MessageBox.Show("Username Must be 8 Characters Long");
                return false;
            }

            using (var connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(1) FROM users_table WHERE username = @Username";
                int count = connection.QuerySingle<int>(query, new
                {
                    Username = username
                });
                if (count > 0)
                {
                    MessageBox.Show("Username already exists.");
                    return false;
                }
            }
            return true;
        }

        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
             return false;

            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&_])[A-Za-z\d@$!%*?&_]{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        

        public bool ValidatePrice(string price)
        {
            if (string.IsNullOrWhiteSpace(price))
            { return false; }               
            if (!decimal.TryParse(price, out decimal priceOut) || priceOut <= 0)
            { return false; }
            return true;
        }
        
        //hindi pa sure
        public bool CheckProductDuplicate(string product)
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(1) FROM products_table WHERE Product_Name = @ProductName";
                int count = connection.Execute(query, new { ProductName = product });
                return count > 0;
            }
           
        }

    }
}
