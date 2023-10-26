using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Transfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { name = "Joe", cash = 50 };
            Guy bob = new Guy() { name = "Bob", cash =100 };
            while (true) 
            {
                joe.WriteMyinfo();
                bob.WriteMyinfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int newCash))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGui = Console.ReadLine();
                    if( whichGui == "Joe")
                    {
                        int cashGive = joe.GiveCash(newCash);
                        bob.ReceiveCash(cashGive);
                    }
                    else if( whichGui == "Bob" )
                    {
                        int cashGive = bob.GiveCash(newCash);
                        joe.ReceiveCash(cashGive);
                    }
                    else
                    {
                        Console.WriteLine("Plase enter an amount ( or a blank line to exit).");
                    }
                }
            }
        }
    }
}
