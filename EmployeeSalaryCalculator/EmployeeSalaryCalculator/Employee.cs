using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Employee
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }

        public int SalaryBonus { get; set; }

        public int Expierence { get; set; }

        public Employee(string name, string surname, string position, int salary, int salaryBonus, int expierence)
        {
            Name = name;
            Surname = surname;
            Position = position;
            Salary = salary;
            SalaryBonus = salaryBonus;
            Expierence = expierence;
        }

        public int GetSalary()
        {
            for (int i = 0; i < Expierence; i++)
            {
                Salary += Salary * SalaryBonus / 100;
            }
            return Salary;
        }

    }  
}
