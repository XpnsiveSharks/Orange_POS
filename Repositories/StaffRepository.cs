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
    internal class StaffRepository : IStaffRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public StaffRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }

        public void AddStaff(Staff staff)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO Staff_table (staff_name, staff_Contact, staff_date) VALUES (@staffName, @staffContact, @staffDate)";
                    connection.Execute(insertQuery, new
                    {
                        Staff_Name = staff.Staff_Name,
                        Staff_Contact = staff.Staff_Contact,
                        Staff_Date = DateTime.Now
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public List<Staff> GetAllStaff()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    return connection.Query<Staff>("SELECT * FROM Staff_table").ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public void UpdateStaff(Staff staffs)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var updateMenu = "UPDATE Menu_table SET Staff_Name = @Staff_Name, Staff_Contact = @Staff_Contact WHERE Staff_Id = @Staff_Id";
                    connection.Execute(updateMenu, new
                    {
                        Staff_Name = staffs.Staff_Name,
                        Staff_Contact = staffs.Staff_Contact,
                        Staff_Id = staffs.Staff_Id
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public void RemoveStaff(int staffID)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var removeStaff = "DELETE  FROM Staff_table WHERE Staff_Id = @Staff_Id";
                    connection.Execute(removeStaff, new { Staff_Id = staffID });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public Staff GetStaffByID(int staffID)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT * FROM Staff_Table WHERE Staff_Id = @Staff_ID";
                    return connection.QuerySingleOrDefault<Staff>(query, new { Staff_Id = staffID });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
