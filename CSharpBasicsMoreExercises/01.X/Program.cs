using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n/2-1; i++)
            {

                Console.Write(new string(' ', i));
                Console.Write(new string('x', 1));
                Console.Write(new string(' ', n - 2 - 2*i));
                Console.Write(new string('x', 1));
                Console.WriteLine();
                //  Console.Write("{0}X{1}X\n", new string(' ', i),3 );
            }

            Console.Write("{0}x{0}\n", new string(' ',(n/2)));

            for (int i = (n/2-1); i >= 0; i--)
            {
                Console.Write(new string(' ', i));
                Console.Write(new string('x', 1));
                Console.Write(new string(' ', n - 2 - 2 * i));
                Console.Write(new string('x', 1));
                Console.WriteLine();
            }
        }
    }
}
