using Orange_POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Repositories
{
    internal interface IOrdersRepository
    {
        void AddOrders(Orders orders);
        string GetOrderNumber();
        int GetOrderIdByOrderNumber(string orderNumber);

    }
}
