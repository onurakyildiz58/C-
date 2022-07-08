using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalp
{
    class Program
    {
        static void Main(string[] args)
        {
            char cvp;
            Console.WriteLine("eğer şekli göremek istersen E yaz istemezsen H yaz ");
            cvp = Convert.ToChar(Console.ReadLine());

            while (cvp == 'E')
            {

                Console.Write("                                     ");
                Console.WriteLine("****************            ****************");
                Console.Write("                                   ");
                Console.WriteLine("*********************      *********************");
                Console.Write("                                 ");
                Console.WriteLine("*************************  *************************");
                Console.Write("                               *");
                for (int p = 1; p < 56; p++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                Console.Write("                              *");
                for (int u = 1; u < 58; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                for (int i = 60; i >= 1; i -= 2)
                {
                    for (int j = 59 - i / 2; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int f = i; f > 0; f--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                    Console.WriteLine("eğer şekli göremek istersen E yaz istemezsen H yaz ");
                    cvp = Convert.ToChar(Console.ReadLine());          
            }         
            Console.ReadKey();
        }
    }
}

