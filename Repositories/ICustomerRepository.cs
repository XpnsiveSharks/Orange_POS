using Orange_POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Repositories
{
    internal interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        string GetCustomerNumber();
        int GetCustomerIdByCustomerNumber(string customerNumber);
    }
}
