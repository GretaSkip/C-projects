using System;
using WarehouseApplication;

namespace Warehose
{
    class Program
    {

        static void Main(string[] args)
        {

            var warehouse = new Warehouse();

            string command = "";

            while (command != "Exit")
            {
                Console.WriteLine("Type Add to add Item");

                if (command.StartsWith("Add"))
                {
                    var itemName = command.Split(" ")[1];
                    warehouse.Add(itemName);

                }

                if (command == "List")
                {
                    warehouse.List();
                }

                if (command.StartsWith("Del"))
                {
                    var itemToAdd = command.Split(" ")[1];
                    warehouse.Remove(itemToAdd);
                }
               
                Console.WriteLine("Type 'Exit' if you want to exit");
                command = Console.ReadLine();
            }

        }
    }
}
