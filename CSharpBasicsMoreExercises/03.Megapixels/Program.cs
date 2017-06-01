using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());
            double pixels = width * height;
            var megaPix = (pixels / 1000000);
            Console.WriteLine("{0}x{1} => {2}MP",width,height, Math.Round(megaPix,1));


        }
    }
}
