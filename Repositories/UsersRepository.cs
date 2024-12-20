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
        private readonly PasswordHashing _passwordHashing;
        private readonly Users users = new Users();
        public UsersRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
            _passwordHashing = new PasswordHashing();
        }
        public UsersRepository(DatabaseConnection databaseConnection, PasswordHashing passwordHashing)
        {
            _databaseConnection = databaseConnection;
            _passwordHashing = passwordHashing;
        }

        

        public bool UpdateUserPassword(string currentPassword, string newPassword)
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
   

        public bool DeleteUser(string username)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    string deleteQuery = "DELETE FROM users_table WHERE Username = @Username";
                    int rowsAffected = connection.Execute(deleteQuery, new { Username = username });
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while deleting the user from the database.", ex);
            }
        }

        public Users getCredentials(string username, string password, string user_role)
        {
            try
            {
                PasswordHashing passwordHashing = new PasswordHashing();
                string enteredPasswordHash = passwordHashing.hashPassword(password);

                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = @" SELECT Username, Email, User_Role, FirstName, MiddleName, LastName, ContactNumber, Password FROM users_table
                                   WHERE Username = @Username AND User_Role = @User_Role AND Password = @Password";
                    var user = connection.QuerySingleOrDefault<Users>(query, new
                    {
                        Username = username,
                        User_Role = user_role,
                        Password = enteredPasswordHash
                    });

                    return user;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while validating credentials.", ex);
            }
        }

        public List<Users> GetAllUsers()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT Username, Email, User_Role, FirstName, MiddleName, LastName, ContactNumber FROM users_table";
                    return connection.Query<Users>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while retrieving users.", ex);
            }
        }

        public bool UpdateUserAccount(string currentuser, string username, string firstName, string lastName, string middleName, string contactNumber, string email)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var updateQuery = "UPDATE users_table SET Username = @Username, FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, ContactNumber = @ContactNumber, Email = @Email " +
                        " WHERE Username = @Currentuser";

                    int rowsAffected = connection.Execute(updateQuery, new
                    {
                        @Username = username,
                        @FirstName = firstName,
                        @MiddleName = middleName,
                        @LastName = lastName,
                        @ContactNumber = contactNumber,
                        @Email = email,
                        @Currentuser = currentuser
                    });

                    if (rowsAffected > 0)
                    {
                        GetUser.Username = username;
                        GetUser.FirstName = firstName;
                        GetUser.LastName = lastName;
                        GetUser.MiddleName = middleName;
                        GetUser.ContactNumber = contactNumber;
                        GetUser.Email = email;
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occurred while accessing the database", ex);
            }
        }


    }

}

