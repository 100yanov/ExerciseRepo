using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
           // string str = "";
            int n1 = a;
            int n2 = n1 + 1;
            int n3 = n2 + 1;
            int n4 = n3 + 1;
            int n5 = n4 + 1;
            if (b - a < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = n1; i < n2; i++)
                {
                    for (int j = i + 1; j < n3; j++)
                    {
                        for (int k = j + 1; k < n4; k++)
                        {

                            for (int l = k + 1; l < n5; l++)
                            {
                                for (int m = l + 1; m <= b; m++)
                                {
                                    Console.Write($"{i} {j} {k} {l} {m}\n");
                                    // str += $"{i} {j} {k} {l} {m}\n";
                                    n5 = m;
                                }
                                n4 = l;
                            }
                            n3 = k;
                        }
                        n2 = j;
                    }
                    n1 = i;
                }
            }

        }
    }
}
