using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
             double budget = double.Parse(Console.ReadLine());
             int n    = int.Parse(Console.ReadLine());
             string item = "";
             double price = 0;
             int count = 0;
             double subtotal = 0;
             double cost = 0;
             int bought = 0;


             for (int i = 0; i < n; i++)
             {

                 item = Console.ReadLine();
                 price = double.Parse(Console.ReadLine());
                 count = int.Parse(Console.ReadLine());

                 if (budget >= price * count)
                 {
                    if (count > 1)
                     {
                         Console.WriteLine("Adding {0} {1}s to cart.",count,item);
                     }
                     else
                     {
                         Console.WriteLine("Adding {0} {1} to cart.", count, item);
                     }
                     budget -= price * count;
                     subtotal += price * count;
                 }
                 else
                 {
                     bought = Convert.ToInt32(Math.Ceiling(budget / price));
                     if(bought>1)
                     {
                         Console.WriteLine("Adding {0} {1}s to cart.", bought, item);
                     }
                     else
                     {
                         Console.WriteLine("Adding {0} {1} to cart.", bought, item);
                     }
                     budget -= bought * price;
                     subtotal+= bought * price;
                 }



             }
             if (bought > 0)
             {
                 Console.WriteLine("Subtotal: ${0:F2}", subtotal);
                 Console.WriteLine("Not enough. We need ${0:F2} more.", Math.Abs(budget - ((count - bought) * price)));
             }
             else
             {
                 Console.WriteLine("Subtotal: ${0:F2}\nMoney left: ${1:F2}", subtotal, budget);
             }
           

            
            
    }
}
