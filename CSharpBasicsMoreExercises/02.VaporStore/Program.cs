using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double price = 0;
            string game = "";
            string list = "";
            double total = 0;

            while (game!="Game Time")
            {
                game = Console.ReadLine();
                switch (game)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    case "Game Time":continue;
                    default: Console.WriteLine("Not Found" ); continue;
                }
                if (price <= balance)
                {
                    balance -= price;
                    total += price;
                    // list += game + "\n";
                    Console.WriteLine("Bought {0}", game);
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                
               
            }
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");

            }
            else
            {
                Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}",total,balance);
            }

        }
    }
}
