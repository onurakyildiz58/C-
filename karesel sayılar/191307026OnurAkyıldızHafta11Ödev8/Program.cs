using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026OnurAkyıldızHafta11Ödev8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, i, f;
            z = 0;
            f = 0;
            do
            {
                Console.Write("Başlangıç Değeri =");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitiş Değeri =");
                y = Convert.ToInt32(Console.ReadLine());

                if (x < y)
                {
                    Console.WriteLine("doğru değer girildi");
                }
                else
                {
                    Console.WriteLine("yanlış değer girildi");
                }

            } while (x > y);

            for (i = x; i <= y; i++)
            {
                z = i * i;
                f = f + z;
                Console.WriteLine(z);
            }
            Console.WriteLine("kare toplamları ="+f);
          
            Console.ReadKey();

        }
    }
}
