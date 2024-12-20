using Orange_POS.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;


namespace Orange_POS.Helpers
{
    internal class PasswordHashing
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;


        public PasswordHashing()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }

        public string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder stringBuilder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }


        public void SaveToDatabase(string username, string passwordHash, string user_role, string firstname, string lastname, string middlename, string contactnumber, string email)
        {

            using (var connection = _databaseConnection.GetConnection())
            {

                string query = "INSERT INTO users_table (Username, Password, User_Role, FirstName, LastName, MiddleName, ContactNumber, Email) VALUES (@username, @password, @user_role, @firstName, @lastName, @middleName, @contactNumber, @email)";
                connection.Execute(query, new
                {
                    @username = username,
                    @password = passwordHash,
                    @user_role = user_role,
                    @firstName = firstname,
                    @lastName = lastname,
                    @middlename = middlename,
                    @contactNumber = contactnumber,
                    @email = email
                });

            }
        }


    }
}
