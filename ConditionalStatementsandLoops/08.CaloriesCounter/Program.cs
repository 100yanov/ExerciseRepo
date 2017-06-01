﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = "";
            int calories = 0;
            for (int i = 0; i < n; i++)
            {
                input =  Console.ReadLine().ToLower();
                switch (input)
                {
                    case "cheese": calories += 500;  break;
                    case "tomato sauce": calories += 150; break;
                    case "salami": calories += 600; break;
                    case "pepper": calories += 50; break;
                }

            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
