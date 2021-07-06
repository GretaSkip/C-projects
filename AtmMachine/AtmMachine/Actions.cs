using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmMachine
{
    class Actions
    {
        private int balance = 0;


        public void Topup(int amount)
        {
            balance += amount;
            Console.WriteLine($"Card balance now: {balance} EUR");
        }



        public void Withdraw(int cash)
        {
           if (cash >= balance)
            {

            if (cash >= 50)
            {
                int fiftyNote = cash / 50;
                int newCash = cash - fiftyNote * 50;

                if (newCash >= 20)
                {
                    int twentyNote = newCash / 20;
                    int newCash1 = newCash - twentyNote * 20;

                    if ( newCash1 >= 10)
                    {
                        int tenNote = newCash1 / 10;
                        int newCash2 = newCash1 - tenNote * 10;

                        if (newCash2 >= 5)
                        {
                            int fiveNote = newCash2 / 5;
                            int newCash3 = newCash2 - fiveNote * 5;
                          
                            if(newCash3 == 0)
                                {
                                    Console.WriteLine($"You have received: {fiftyNote} 50 EUR {twentyNote} 20 EUR {tenNote} 10 EUR {fiveNote} 5 EUR ");
                                }
                        }
                    }
                }

            }
               
            }

            
        }

       
    }
}

