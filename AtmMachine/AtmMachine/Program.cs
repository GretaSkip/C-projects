using System;

namespace AtmMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new Actions();

            string command = "";

            Console.WriteLine("Possible commands: Exit, Topup, Withdraw");
            while (command != "Exit")
            {
                command = Console.ReadLine();

                if (command.StartsWith("Topup"))
                {
                    string amount = command.Split(" ")[1];
                    int parseAmount = Int32.Parse(amount);
                    actions.Topup(parseAmount);
                }

                if (command.StartsWith("Withdraw"))
                {
                    string cash = command.Split(" ")[1];
                    int parseCash = Int32.Parse(cash);
                    actions.Withdraw(parseCash);
                }
            }

        }
    }
}
