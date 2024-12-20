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
       [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Views.SharedViews.MainLoginView());
            //Application.Run(new Views.StaffViews.StaffIndexView());
            //Application.Run(new Views.AdminViews.AdminIndexView());
            Application.Run(new Views.CustomerViews.OrderTypeView());
        }
    }
}