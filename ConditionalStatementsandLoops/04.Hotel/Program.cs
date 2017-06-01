using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;
          //  double discountStudio = 0;
          //  double discountDouble = 0;
          //  double discountSuite = 0;

            // May, June, July, August, September, October or December
            switch (month)
             
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75; break;
                   

                case "June":
                case "September":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82; break;

                case "July": 
                case "August": 
                case "December":
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89; break;

            }
          if ((month ==  "May" || month== "October")&& days>7)
            {
                priceStudio -= priceStudio*0.05;
            }
          if ((month== "June" || month== "September") && days > 14)
            {
                priceDouble -= priceDouble* 0.1;
            }
          if (days>14 &&(month== "July"|| month == "August" || month == "December"))
            {
                priceSuite -= priceSuite * 0.15;
            }
            if ((month == "September" || month == "October") && days > 7)
            {
                Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.",
                priceStudio * (days - 1), priceDouble * days, priceSuite * days);
            }
            else
            {
                Console.WriteLine("Studio: {0:F2} lv.\nDouble: {1:F2} lv.\nSuite: {2:F2} lv.",
               priceStudio * days, priceDouble * days, priceSuite * days);
            }


        }
    }
}
