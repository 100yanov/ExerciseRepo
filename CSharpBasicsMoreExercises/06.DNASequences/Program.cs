using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int match = int.Parse(Console.ReadLine());
            int sum = 0;
            string sequance = "";
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        sequance = ($"{i}{j}{k}");
                        sequance = sequance.Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T');


                        if (i + j + k >= match)
                        {
                            Console.Write($"O{sequance}O ");
                        }
                        else
                        {
                            Console.Write($"X{sequance}X ");
                        }
                        if (k % 4 == 0)
                        {
                            Console.WriteLine();
                        }

                    }
                  
                }
               
            }
        }
    }
}
