using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int bigger = n1;
            int smaller = n2;
            if (n2 > n1) {
                bigger = n2;
                smaller = n1;
            }
            for (int i = smaller; i <= bigger; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
