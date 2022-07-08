using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("ilk sayıyı giriniz =");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ikinci sayıyı giriniz =");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                
                Console.WriteLine(c);
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }
            Console.ReadKey();
        }
    }
}

