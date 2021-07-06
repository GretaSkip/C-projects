using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Junior_Developer : Employee
    {
        public Junior_Developer(string name, string surname, int expierence) : base(name, surname, "Junior Developer", 1000, 5, expierence)
        {
            
        }
    }
}
