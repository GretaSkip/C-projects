using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApplication
{
    class Warehouse
    {
        private List<string> Items = new List<string>();


        public void Add(string item)
        {
            Items.Add(item);
        }

        public void List()
        {
            Console.WriteLine(String.Join(",", Items));
        }

        public void Remove(string itemName)
        {
            Items.Remove(itemName);
        }
    }
}
