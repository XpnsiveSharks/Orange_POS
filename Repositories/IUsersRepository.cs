using Orange_POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Repositories
{
    internal interface IUsersRepository
    {
        bool UpdateUserPassword(string currentPassword, string newPassword);
        List<Users> GetAllUsers();
        bool DeleteUser(string username);
        bool UpdateUserAccount(string currentuser,string username, string firstName, string lastName, string middleName, string contactNumber, string email);

    }
}
