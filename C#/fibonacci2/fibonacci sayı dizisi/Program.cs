using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_sayı_dizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("sayı dizisinin ilk kaç sayısının gösterileceğini belirleyin");
            x = Convert.ToInt32(Console.ReadLine());
            int[] fibonacci = new int[x];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < x; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            for (int j = 0; j < x; j++)
            {
                Console.Write(" "+ fibonacci[j]);
            }

            Console.ReadKey();
        }
    }
}
