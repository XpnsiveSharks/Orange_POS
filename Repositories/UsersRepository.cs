using Orange_POS.Configurations;
using Orange_POS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Orange_POS.Helpers;

namespace Orange_POS.Repositories
{
    internal class UsersRepository : IUsersRepository
    {

        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        private readonly Users users = new Users();
        public UsersRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public bool UpdateUsers(string currentPassword, string newPassword)
        {
            PasswordHashing passwordHashing = new PasswordHashing();
            string currentPasswordHash = passwordHashing.hashPassword(currentPassword);
            string newPasswordHash = passwordHashing.hashPassword(newPassword);

            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT Password FROM users_table WHERE Password = @CurrentPassword";
                    var storedPassword = connection.QuerySingleOrDefault<string>(query, new { @CurrentPassword = currentPasswordHash });


                    if (storedPassword == null)
                    {
                        return false;
                    }

                    var updateQuery = "UPDATE users_table SET Password = @NewPassword WHERE Password = @CurrentPassword";
                    int rowsAffected = connection.Execute(updateQuery, new
                    {
                        @CurrentPassword = currentPasswordHash,
                        @NewPassword = newPasswordHash
                    });

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }


        }
        public List<Users> GetUser(string usersPassword)
        {
            PasswordHashing passwordHashing = new PasswordHashing();
            string passwordHash = passwordHashing.hashPassword(usersPassword);

            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT * FROM users_table WHERE Password = @Password";
                    return connection.Query<Users>(query, new { @Password = passwordHash }).ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occurred while accessing the database.", ex);
            }
        }

        public bool DeleteUser(string username, string password)
        {
            PasswordHashing passwordHashing = new PasswordHashing();
            string hashedPassword = passwordHashing.hashPassword(password);

            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    string deleteQuery = "DELETE FROM users_table WHERE Username = @Username AND Password = @Password";
                    int rowsAffected = connection.Execute(deleteQuery, new
                    {
                        @Username = username,
                        @Password = hashedPassword
                    });

                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while deleting the user from the database.", ex);
            }
        }

    }
}
