using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        string name;
        string surname;
        int age;
        int[] grades;


        public Student()
        {

        }

        public Student(string name, string surname, int age, int[] grades)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.grades = grades;
        }

        public string GetName(string name)
        {
            return this.name;
        }

        public string GetSurname(string surname)
        {
            return this.surname;
        }

        public void GetAge(int age)
        {
            return this.age;
        }

        public void GetGrades(int age)
        {
            return this.age;
        }
    }
}
