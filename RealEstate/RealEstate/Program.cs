using System;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateApp
{
    class Program
    {

        static void Main(string[] args)
        {
            List<RealEstate> realEstateFlats = new List<RealEstate>();

            realEstateFlats.Add(new RealEstate("flat", 500000, 72.8, "Vilnius"));
            realEstateFlats.Add(new RealEstate("house", 380000, 49.8, "Kaunas"));
            realEstateFlats.Add(new RealEstate("flat", 570000, 38.8, "Klaipeda"));
            realEstateFlats.Add(new RealEstate("flat", 10000000, 100.8, "Kaunas"));
            realEstateFlats.Add(new RealEstate("house", 8900000, 47.8, "Vilnius"));
            realEstateFlats.Add(new RealEstate("house", 8900000, 45.7, "Vilnius"));

            for (int i = 0; i < realEstateFlats.Count; i++)
            {
                Console.WriteLine(realEstateFlats[i]);
            }


            List<RealEstate> SortedList = realEstateFlats.OrderBy(o => o.sqMPrice()).ToList();
        }

        
    }
}
