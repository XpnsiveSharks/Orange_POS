using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Models
{
    internal class OrderDetails
    {
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string OrderType { get; set; }
        public decimal TotalAmount { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
