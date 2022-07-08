using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kare_alan_ve_çevre_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, alan, cevre;
            Console.WriteLine("karenin bir kenarını giriniz=");
            x = Convert.ToInt32(Console.ReadLine());

            alan = x * x;
            cevre = x * 4;
            Console.WriteLine("alan=" + alan);
            Console.WriteLine("çerve=" + cevre);
            Console.ReadKey();
        }
    }
}
