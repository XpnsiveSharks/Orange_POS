using Orange_POS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orange_POS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      //  [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Views.AdminViews.AdminIndexView());

            InputValidation validation = new InputValidation();

            
            string username = "TESTUSER";
            string password = "Passwordlang";

            if (validation.ValidateUsername(username))
            {
                Console.WriteLine("Invalid username. Must be unique,  at least 7 characters, max of 10");
                return;
            }
       

            if (validation.ValidatePassword(password))
            {
                Console.WriteLine("Invalid password. Must contain capital letters, characters, and numbers.");
                return;
            }

        }
    }
}