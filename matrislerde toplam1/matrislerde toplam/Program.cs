using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrislerde_toplam
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("ilk dizi=");
            int[,] dizi1 = new int[2, 2];
            dizi1[0, 0] = 5;
            dizi1[0, 1] = 9;
            dizi1[1, 0] = 4;
            dizi1[1, 1] = 6;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(" {0} ", dizi1[i, j]);
                    Console.WriteLine();
            }
        
            Console.WriteLine("ikinci dizi=");
            int[,] dizi2 = new int[2, 2];
            dizi2[0, 0] = 84;
            dizi2[0, 1] = 2;
            dizi2[1, 0] = 8;
            dizi2[1, 1] = 2;
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                    Console.Write(" {0} ", dizi2[a, b]);
                    Console.WriteLine();
            }

            int x, c, v, n;
            Console.WriteLine(" toplam sonuçları=");
            int[,] sonuc = new int[2, 2];
            x = dizi1[0, 0] + dizi2[0, 0];
            c = dizi1[0, 1] + dizi2[0, 1];
            v = dizi1[1, 0] + dizi2[1, 0];
            n = dizi1[1, 1] + dizi2[1, 1];

            Console.WriteLine("0,0 indisi =" + x);
            Console.WriteLine("0,1 indisi =" + c);
            Console.WriteLine("1,0 indisi =" + v);
            Console.WriteLine("1,1 indisi =" + n);

            Console.ReadKey();
        }
    }
}
