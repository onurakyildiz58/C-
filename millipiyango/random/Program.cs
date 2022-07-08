
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        private static Random random = new Random();
        
        static void Main(string[] args)
        {
            int[] millipiyango = new int[7];
            int x, y;

            for (x = 0; x <= 6; x++)
            {
                Random millipyango = new Random();
                millipiyango[x] = random.Next(8);
            }

            for (y = 0; y <= 6; y++)
            {
                Console.WriteLine(y + 1 + ".sayı=" + millipiyango[y]);

            }
            
            Console.ReadKey();
        }

        
    }
}
