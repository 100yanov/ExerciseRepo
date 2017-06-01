using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sizeB = int.Parse(Console.ReadLine());
            string sizeConv = "";

            
            if (sizeB > 1000000.0) {
                sizeConv = $"{Convert.ToDouble(sizeB / 1000000.0)}MB";
            }
            else if(sizeB>1000){
                sizeConv = $"{Convert.ToDouble(sizeB / 1000.0)}KB";
            }
            else
            {
                sizeConv = $"{sizeB}B";
            }

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string orientation = "";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }


            Console.WriteLine("Name: DSC_{0:D4}.jpg",name);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2} {3:D2}:{4:D2}", day,month, year,hours, minutes);
            Console.WriteLine("Size: {0}",sizeConv);
            Console.WriteLine("Resolution: {0}x{1} ({2})",width, height, orientation);
        }
    }
}
