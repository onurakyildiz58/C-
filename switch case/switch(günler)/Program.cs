using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_günler_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("1-7 arasında bir sayı giriniz =");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)

            {
                case 1: Console.WriteLine("pazartesi");
                    break;
                case 2: Console.WriteLine("salı");
                    break;
                case 3: Console.WriteLine("çarşamba");
                    break;
                case 4: Console.WriteLine("perşembe");
                    break;
                case 5: Console.WriteLine("cuma");
                    break;
                case 6: Console.WriteLine("cumartesi");
                    break;
                case 7: Console.WriteLine("pazar");
                    break;
                default:Console.WriteLine("geçersiz gün");
                    break;
            }

            Console.ReadKey();


        }
    }
}
