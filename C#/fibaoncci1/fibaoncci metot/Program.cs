using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibaoncci_metot
{
    class Program
    {
        public static void fibonacci()
        {
            int x;
            Console.Write("boyut belirleyin =");
            x = Convert.ToInt32(Console.ReadLine());

            int[] fib = new int[x];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < x; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (int j = 0; j < x; j++)
            {
                Console.WriteLine(fib[j]);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("fibonacci sayı dizisine hg");
            
            fibonacci();
            Console.ReadKey();
        }
    }
}
