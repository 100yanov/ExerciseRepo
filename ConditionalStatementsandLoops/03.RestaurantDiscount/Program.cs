using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int GroupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double pricePackage = 0;
            double discount = 0.0;
            double priceHall = 0.0;
            double priceall = 0.0;
            string hall = "";
            switch (package){
                case "Normal": discount = 0.05; pricePackage = 500; break;
                case "Gold": discount = 0.10; pricePackage = 750; break;
                case "Platinum": discount = 0.15; pricePackage = 1000; break;
            }
            if (GroupSize > 0 && GroupSize <= 120)
            {

                if (GroupSize <= 50)
                {
                    priceHall = 2500;   
                    hall = "Small Hall";
                }
                else if (GroupSize <= 100)
                {
                    priceHall = 5000;
                    hall = "Terrace";
                }
                else if (GroupSize <= 120)
                {
                    priceHall = 7500;
                    hall = "Great Hall";
                }
                priceall = (priceHall + pricePackage);
                priceall -= priceall * discount;
                Console.WriteLine("We can offer you the {0}\nThe price per person is {1:F2}$", hall, priceall / GroupSize);
                
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            

        }
    }
}
