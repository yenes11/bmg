using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad; int e, y;
            Console.WriteLine("Adınızı giriniz=");
            ad = Console.ReadLine();
            e = ad.Length;
            for (int i = 0; i < e; i++)
            {
                y = (int)ad[i] + 10;
                Console.Write((char)y);
            }
            Console.ReadKey();
          
        }
    }
}
