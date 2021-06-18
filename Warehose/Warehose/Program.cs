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

                if (command.StartsWith("Add"))
                {
                    var itemName = command.Split(" ")[1];
                    warehouse.Add(itemName);

                }

                if (command == "List")
                {
                    warehouse.List();
                }

                if (command.StartsWith("Remove"))
                {
                    var itemToRemove = command.Split(" ")[1];
                    warehouse.Remove(itemToRemove);
                }
                  
                command = Console.ReadLine();
            }

        }
    }
}
