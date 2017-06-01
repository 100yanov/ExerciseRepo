using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int n = 0;
            try
            {


                while (true)
                {
                    n = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch {
                Console.WriteLine(counter);
            }
        }
    }
}
