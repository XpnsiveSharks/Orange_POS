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
        bool UpdateUsers(string currentPassword, string newPassword);
        List<Users> GetUser(string usersPassword);
        bool DeleteUser(string username, string password);

    }
}
