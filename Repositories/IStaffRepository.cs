using Orange_POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange_POS.Repositories
{
    internal interface IStaffRepository
    {
        void AddStaff(Staff staff);
        List<Staff> GetAllStaff();
        void UpdateStaff(Staff staffs);
        void RemoveStaff(int staffID);
        Staff GetStaffByID(int staffID);

    }
}
