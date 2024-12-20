using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Models
{
    internal class Users
    {
        public  string Username { get; set; }
        public  string Email { get; set; }
        public  string User_Role { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Middlename { get; set; }
        public  string Password { get; set; }
        public  string Contactnumber { get; set; }
    }
    public class GetUser
    {
        public static string Username { get; set; }
        public static string User_Role { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static string LastName { get; set; }
        public static string ContactNumber { get; set; }
        public static string Email { get; set; }
    }

}
