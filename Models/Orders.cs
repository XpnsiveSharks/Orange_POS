using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Models
{
    internal class Orders
    {
        public int Order_Id { get; set; }
        public string Order_Number { get; set; }
        public string Order_Date { get; set; }
        public string Order_Type { get; set; }
        public int Customer_Id { get; set; }
        public double Total_Amount { get; set; }
        public string Status { get; set; }
        public string Payment_Method { get; set; }
    }
}
