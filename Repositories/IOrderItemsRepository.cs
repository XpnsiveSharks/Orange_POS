using Orange_POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Repositories
{
    internal interface IOrderItemsRepository
    {
        void AddOrderItems(OrderItems orderItems);

    }
}
