using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
        class Program
        {
            private static Random random = new Random();
        private static object surnames;

        static void Main(string[] args)
            {

                List<List<String>> mokiniai = new List<List<String>>();

                List<String> vardai = new List<String>();
                List<String> pavardes = new List<String>();
                List<String> amziai = new List<String>();
                vardai.Add("Petras");
                vardai.Add("Kestas");
                vardai.Add("Vaida");

                pavardes.Add("Petruškevičius");
                pavardes.Add("Levickis");
                pavardes.Add("Skiparė");

                amziai.Add("7");
                amziai.Add("septyniolika");
                amziai.Add("šešiolika");


                mokiniai.Add(vardai);
                mokiniai.Add(pavardes);
                mokiniai.Add(amziai);


                List<Student> students = new List<Student>();
            string[] names = { "Petras", "Jonas", "Vardenis", "Marija", "Dovile" };
            string[] surnames = { "Juozaitis", "Petratis", "Nevinckas", "Skipare", "Kazakaviciene" };


                //Student st = new Student();
                //st.SetName("Andrius");
                //Student st2 = new Student("sd", "sd", 7,new int[]{ 4, 5, 6 });

                //students.Add(st);
                //students.Add(st2);

                //students.Add(new Student("Naglis", "Mockevicius", 31, new int[] { 10, 10, 10, 10, 10, 10, 10, 10 }));
                //students.Add(new Student("Petras", "Jonavicius", 31, new int[] { 10, 10, 10, 10, 10, 10, 10, 10 }));
                //students.Add(new Student("Naglis", "Mockevicius", 31, new int[] { 10, 10, 10, 10, 10, 10, 10, 10 }));
                //students.Add(new Student("Naglis", "Mockevicius", 31, new int[] { 10, 10, 10, 10, 10, 10, 10, 10 }));


                for (int i = 0; i < 10; i++)
                {
                students.Add(new Student(names[random.Next(0, names.Length - 1)], surnames[random.Next(0, names.Length - 1)], random.Next(18, 60), numArr(3, 14, 1, 10)));
            }

                Console.WriteLine(students.Count);

                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine(students[i].ToString());
                }

                students[5].SetName("Mindaugas");
                students[5].SetSurname("Nevinskas");
                students[5].SetGrades(new int[] { });

                //for (int i = 0; i < students.Count; i++)
                //{
                //    Console.WriteLine(students[i].ToString());
                //}

            for (int i = 0; i < students.Count; i++)
            {
                for (int a = 0; a < students.Count; a++)
                {
                    if(students[a].avg() > students[i].avg()) { 
                    Student tmp = students[a];
                    students[a] = students[i];
                    students[i] = tmp;
                    }
                }
            }


            }
            public static int[] numArr(int arrMin, int arrMax, int valMin, int valMax)
            {
                int[] numArr = new int[random.Next(arrMin, arrMax)];
                for (int a = 0; a < numArr.Length; a++)
                {
                    numArr[a] = random.Next(valMin, valMax + 1);
                }
                return numArr;
            }

            public static string RandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }



        }
    }
