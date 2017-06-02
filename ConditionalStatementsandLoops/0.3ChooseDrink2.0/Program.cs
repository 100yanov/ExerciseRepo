using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//!!!!!!!!!!adding another line, to master branch!!!!!!!!!

namespace _0._3ChooseDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
                
            string input = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            switch (input)
            {
                case "Athlete": price = 0.7;  break;
                case "Businessman":
                case "Businesswoman": price = 1.00; break;
                case "SoftUni Student": price = 1.7; break;
                default: price = 1.2; break;
            }
            Console.WriteLine("The {0} has to pay {1:F2}", input, price * quantity);
            
        }
    }
}
