using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Architect : Employee
    {
        public Architect(string name, string surname, int expierence): base(name, surname,"Architect", 3500, 20, expierence)
        {
            
        }
    }
}
