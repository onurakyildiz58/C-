using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iki boyutlu diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!! 2 boyutlu diziler !!!");
            
            int[,] dizi = new int[2, 2];
            dizi[0, 0] = 10;
            dizi[0, 1] = 20;
            dizi[1, 0] = 30;
            dizi[1, 1] = 40;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(" {0} ", dizi[i, j]);
                    Console.WriteLine();
            }

            Console.Read();


        }
    }
}
