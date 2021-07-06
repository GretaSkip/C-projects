using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSalaryCalculator
{
    class Program
    {
        private static List<Employee> _employess = new List<Employee>();

        static void Main(string[] args)
        {
                string command = "";

                while (command != "Exit")
                {
                    command = Console.ReadLine();
                try
                {
                    if (command.StartsWith("Add"))
                    {
                        string name = command.Split(" ")[1];
                        string surname = command.Split(" ")[2];
                        string position = command.Split(" ")[3];
                        string expierence = command.Split(" ")[4];
                        int parsExpierence = Int32.Parse(expierence);

                        if (position == "JuniorDeveloper") 
                        {
                            Junior_Developer PositionJuniorDeveloper = new Junior_Developer(name, surname, parsExpierence);
                            
                            _employess.Add(PositionJuniorDeveloper);
                        }

                        if (position == "Developer")
                        {
                            Developer PositionDeveloper = new Developer(name, surname, parsExpierence);

                            _employess.Add(PositionDeveloper);
                        }

                        if (position == "SeniorDeveloper")
                        {
                            Senior_Developer PositionSeniorDeveloper = new Senior_Developer(name, surname, parsExpierence);

                            _employess.Add(PositionSeniorDeveloper);

                        }

                        if (position == "Architect")
                        {
                            Architect PositionArchitect = new Architect(name, surname, parsExpierence);

                            _employess.Add(PositionArchitect);
                        }

                    }
                    if (command.StartsWith("Show"))
                    {
                        string name = command.Split(" ")[1];
                        string surname = command.Split(" ")[2];
                        
                        Employee employee = _employess.FirstOrDefault(e => e.Name == name && e.Surname == surname);
                        Console.WriteLine($"Salary is {employee.GetSalary()} EUR");
                        
                    }

                }
                catch (ArgumentNullException)
                {

                }
                catch (Exception)
                {
                    Console.WriteLine("Something gone wrong, please try again");
                }

                }
        }
    }
}
