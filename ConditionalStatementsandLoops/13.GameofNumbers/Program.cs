using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            int a = 0;
            int b = 0;
            bool found = false;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    
                    counter++;
                    if (i + j == magic)
                    {
                        found = true;
                        a = i;
                        b = j;
                        
                    }
                }
            }
           if (found)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", a, b, a + b);
              
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magic);
            }
        
        }
    }
}
