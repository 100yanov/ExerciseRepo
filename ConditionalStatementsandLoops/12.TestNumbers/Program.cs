using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxSum = 0;
            int counter = 0;
            
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                   // maxSum += (i * j) * 3;
                    if (sum >= stop)
                    {
                        break;
                    }
                    counter++;
                    sum += (i * j) * 3;

                }
            }

            Console.WriteLine("{0} combinations",counter);
            if (sum < stop)
            {
                Console.WriteLine("Sum: {0}", sum);
            }
            else
            {
                Console.WriteLine("Sum: {0} >= {1}", sum,stop);
            }
            
            
        }
    }
}
