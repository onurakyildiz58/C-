using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdörtgen_alan_ve_çevre_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, alan, cevre, y;
            Console.Write("lütfen birinci kenar giriniz= ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("lütfen ikinci kenar giriniz= ");
            y = Convert.ToInt32(Console.ReadLine());

            alan = x * y;
            cevre = (x + y) * 2;

            Console.WriteLine("alan =" + alan);
            Console.WriteLine("çevre =" + cevre);

            Console.ReadKey();
        }
    }
}
