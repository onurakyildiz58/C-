using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterlerden_şekil_çizme_vol._2
{
    class Program
    {
        static void Main(string[] args)
        {

            // girilen kenar sayısında kare yazan kısım

            int kenar;
            Console.Write("kenar değeri giriniz =");
            kenar = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("içi dolu hali =");

            for (int i = 1; i <= kenar; i++)
            {
                for (int j = 0; j < kenar; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // içi boş kare yapımı 
            Console.WriteLine();
            Console.WriteLine("içi boş hali =");
            //üst kenar
            for (int k = 0; k < kenar; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            //sol kenar
            for (int n = 0; n < kenar - 2; n++)
            {
                Console.Write("*");
                //aradaki boşluklar
                for (int m = 0; m < kenar - 2; m++)
                {
                    Console.Write("  ");
                }
                //sağ kenar
                Console.Write(" *");
                Console.WriteLine();
            }
            //alt kenar
            for (int b = 0; b < kenar; b++)
            {
                Console.Write("* ");
            }
            
            Console.ReadKey();
        }
    }
}
