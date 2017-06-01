using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            while (true)
            {
                if (input == "Bake!")
                {
                    break;
                }
                counter++;
                Console.WriteLine("Adding ingredient {0}.", input);
                input = Console.ReadLine();

            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
