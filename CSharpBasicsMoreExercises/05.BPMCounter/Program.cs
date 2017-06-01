using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int BPM = int.Parse(Console.ReadLine());
            int beats  = int.Parse(Console.ReadLine());
            double bars = (Convert.ToDouble(beats) / 4.0);
            bars = Math.Round(bars, 1);
            double time =  beats/ Convert.ToDouble(BPM);
            int minutes = Convert.ToInt32( Math.Floor(time));
            double seconds = (time-minutes)*60;
            seconds = Math.Floor(seconds);
            Console.WriteLine("{0} bars - {1}m {2}s",bars,minutes,seconds);
        }
    }
}
