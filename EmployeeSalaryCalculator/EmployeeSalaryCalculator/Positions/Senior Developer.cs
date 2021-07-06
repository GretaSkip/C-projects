using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Senior_Developer : Employee
    {
        public Senior_Developer(string name, string surname, int expierence) : base(name, surname, "Senior developer", 2500, 15, expierence)
        {

        }
    }
}
