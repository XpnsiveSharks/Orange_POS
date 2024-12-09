using Dapper;
using Orange_POS.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            if (string.IsNullOrEmpty(username) || username.Length < 7 || username.Length > 10) 
                return false;

            using (var connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(1) FROM users_table WHERE username = @Username";
                int count = connection.QuerySingle<int>(query, new
                {
                    Username = username
                });
                return count == 0;
            }
        }

        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
             return false;

            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8, }$";
            return Regex.IsMatch(password, pattern);


        }

        
    }
}
