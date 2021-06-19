using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp
{
    class RealEstate
    {
        string house;
        double price;
        double size;
        string city;

        public RealEstate()
        {

        }
        public RealEstate(string house, double price, double size, string city)
        {
            this.house = house;
            this.price = price;
            this.size = size;
            this.city = city;
        }

        public string GetHouse()
        {
            return this.house;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public double GetSize()
        {
            return this.size;
        }
        public string GetCity()
        {
            return this.city;
        }


        public void SetHouse(string house)
        {
            this.house = house;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void SetSize(double size)
        {
            this.size = size;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }

        public override string ToString()
        {
            string flat = "Type: " + this.house + " price: " + this.price + " Eur" + " size: " + this.size + " m² " + " city: " + this.city + " sqMPrice: " + sqMPrice() + " Eur";
            return flat;
        }

        public double sqMPrice()
        {
            var mPrice = this.price / this.size;
            var roundedmPrice = Math.Round(mPrice, 2);
            return roundedmPrice;
        }
    }
}
