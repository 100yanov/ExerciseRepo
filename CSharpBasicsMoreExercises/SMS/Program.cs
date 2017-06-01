using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int offset = 0;
            int main = 0;
            string input = "";
            
            int n = int.Parse(Console.ReadLine());
            int numberOfDigits = 0;
            int letterPos = 0;
            char ch = ' ';
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                main = Convert.ToInt16(new string(input[0],1));
                numberOfDigits = input.Length;
              
               
                    offset = (main - 2) * 3;
                
                if(main==8||main==9)
                {
                    offset +=1 ;
                }
                letterPos = offset + numberOfDigits - 1;
                ch = Convert.ToChar( 97 + letterPos );
                if (input == "0")
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(ch);
                }
            }
            
        }
    }
}
