using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Developer : Employee
    {
        public Developer(string name, string surname, int expierence) : base(name, surname, "Developer", 2000, 10, expierence)
        {

        }
    }
}
