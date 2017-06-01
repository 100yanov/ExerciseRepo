using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDmg = int.Parse(Console.ReadLine());
            int GoshoDmg = int.Parse(Console.ReadLine());
            int PeshoHlth = 100;
            int GoshoHlth = 100;
            int round = 0;
            while (true)
            {
                round++;
                if (round % 2 == 1)
                {
                    GoshoHlth -= PeshoDmg;
                    
                    if (GoshoHlth <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", round);
                        break;
                    }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GoshoHlth);

                }
                

                
                if (round % 2 == 0)
                {
                    PeshoHlth -= GoshoDmg;
                  
                    if (PeshoHlth <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", round);
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PeshoHlth);

                }
                if (PeshoHlth > 0 && GoshoHlth > 0 && round%3==0)
                {
                    PeshoHlth = PeshoHlth + 10;
                    GoshoHlth = GoshoHlth + 10;
                }






            }
        }
    }
}
