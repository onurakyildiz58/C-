using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotların_taşması
{
    class Program
    {
        static void islem (int [] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                d[i] += 1;
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            int[] dizi = { 3, 4, 5 };
            foreach (var i in dizi)
            {
                Console.WriteLine(i);
            }
            islem(dizi);
            foreach (var y in dizi)
            {
                Console.WriteLine(y);
            }

            Console.ReadKey();
        }
    }
}
