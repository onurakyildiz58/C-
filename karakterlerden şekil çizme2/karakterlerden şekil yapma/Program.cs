using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterlerden_şekil_yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            //normal 10x10 dik üçgen yazar
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            //önceki 10x10 dik üçgeni y eksenine göre test çevirir
            for (int j = 10; j >= 1; j--)
            {
                for (int m = j; m > 0; m--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
