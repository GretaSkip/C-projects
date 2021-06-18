using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<String>> mokiniai = new List<List<String>>();

            List<String> vardai = new List<String>();
            List<String> pavardes = new List<String>();
            List<String> amziai = new List<String>();

            vardai.Add("Petras");
            pavardes.Add("Petruskevicius");
            amziai.Add("septyni");

            vardai.Add("Vardenis");
            pavardes.Add("Pavardenis");
            amziai.Add("septyniolika");

            mokiniai.Add(vardai);
            mokiniai.Add(pavardes);
            mokiniai.Add(amziai);

            Student st = new Student();











            //for (int i = 0; i < mokiniai[0].Count; i++)
            //{
            //    for (int a = 0; a < mokiniai.Count; a++)
            //    {
            //        Console.WriteLine(mokiniai[a][i]);
            //        Console.WriteLine("---------------");
            //    }
            //}

            //mokiniai[2][1] = "dvidesimt"; //pirma nurodom elementa kuri keiciam ir poto pozicija

            //for (int i = 0; i < mokiniai[0].Count; i++)
            //{
            //    for (int a = 0; a < mokiniai.Count; a++)
            //    {
            //        Console.WriteLine(mokiniai[a][i]);
            //        Console.WriteLine("---------------");
            //    }
            //}

           


            // skaiciu rykiavimas
            //List<int> skaiciai = new List<int> { 1, 7, 8, 9, 2, 5, 6 };

            //for (int i = 0; i < skaiciai.Count; i++)
            //{
            //    Console.WriteLine(skaiciai[i] + " ");
            //}

            //Console.WriteLine("");
            // paprastas sortas

            //for (int a = 0; a < skaiciai.Count; a++)
            //{
            //    for (int i = 0; i < skaiciai.Count - 1; i++)
            //    {
            //        if (skaiciai[i] > skaiciai[i + 1])
            //        {
            //        int tmp = skaiciai[i];
            //        skaiciai[i] = skaiciai[i + 1];
            //        skaiciai[i + 1] = tmp;
            //         }
            //    }
            //}

            //for (int a = 0; a < skaiciai.Count; a++)
            //{
            //    for (int i = a + 1; i < skaiciai.Count; i++)
            //    {
            //        if (skaiciai[a] > skaiciai[i])
            //        {
            //            int tmp = skaiciai[a];
            //            skaiciai[a] = skaiciai[i];
            //            skaiciai[i] = tmp;
            //        }
            //    }
            //}

            //for (int i = 0; i < skaiciai.Count; i++)
            //{
            //    Console.WriteLine(skaiciai[i] + " ");
            //}
            //Console.WriteLine("");
        }

    }
}
