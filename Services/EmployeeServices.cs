using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeServices
    {
        private NORTHWNDEntities db = new NORTHWNDEntities();
        public List<Employee> GetAllEmployees()
        {
            var employees =
            (from e in db.Employees
             select e).ToList();

            return employees;
        }
    }
}
