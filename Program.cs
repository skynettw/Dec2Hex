using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec2Hex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string symbols = "0123456789ABCDEF";
            string hex_number = "";
            Console.Write("請輸入您要轉換的10進位數字：");
            number = Convert.ToInt32(Console.ReadLine());  
            while (number > 1)
            {
                hex_number = (symbols[number % 16]).ToString() + hex_number;
                number /=16 ;
            }
            Console.WriteLine("Hex numbers is {0}", hex_number);
            Console.ReadLine();
        }
    }
}
