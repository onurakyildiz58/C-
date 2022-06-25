using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldızÖdev4.txt
{
    class Program
    {
        static void fibiteratif()
        {
            int x;
            Console.Write("boyut belirleyin =");
            x = Convert.ToInt32(Console.ReadLine());
            x++;
            int[] fib = new int[x];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < x; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            for (int j = 0; j < x; j++)
            {
                if (j == x-1)
                {
                    Console.WriteLine(x-1 + ". sıradaki fibonacci değeri =" + fib[j] + " iteratif");
                }
            }
        }

        private static int Fibözyinelemeli(int boyut)
        {
            if (boyut <= 1)
            {
                return boyut;
            }
            else
            {
                return Fibözyinelemeli(boyut - 1) + Fibözyinelemeli(boyut - 2);
            }
        }
        static int sonuc = 1;
        static void us(int taban, int üs)
        {  
            sonuc = sonuc * taban;
            if (üs==1)
            {
                Console.Write(taban+" üzeri "+üs+" =");
                Console.WriteLine(sonuc); 
            }  
            else
                us(taban,üs-1);
        }
        static void Main(string[] args)
        {
            string cevap;
            int seçim,taban, üs;
            do
            {
                Console.WriteLine("1 - Fibonacci Hesaplama(iteratif)");
                Console.WriteLine("2 - Fibonacci Hesaplama(özyinelemeli)");
                Console.WriteLine("3 - Us alma(özyinelemeli)");
                Console.WriteLine("4 - Çıkış");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz:");
                seçim = Convert.ToInt32(Console.ReadLine());
                switch (seçim)
                {
                    case 1:
                        Console.WriteLine("fibonacci iteratif dizisi :");
                        fibiteratif();
                        break;
                    case 2:
                        Console.WriteLine("fibonacci özyinelemeli dizisi :");
                        Console.WriteLine("istediğiniz indisi giriniz");
                        int değer;
                        değer = Convert.ToInt32(Console.ReadLine());
                        int fibonacci = Fibözyinelemeli(değer);
                        Console.WriteLine(değer+". sıradaki fibonacci değeri :"+fibonacci+ " özyinelemeli");
                        break;
                    case 3:
                        Console.WriteLine("üs almak istediğiniz sayıları giriniz :");
                        Console.Write("taban :");
                        taban = Convert.ToInt32(Console.ReadLine());
                        Console.Write("üs :");
                        üs= Convert.ToInt32(Console.ReadLine());
                        us(taban, üs);
                        break;
                    case 4:
                        Console.WriteLine("çıkış seçildi...");
                        Console.WriteLine("çıkılıyor...");
                        break;
                    default:
                        Console.WriteLine("geçersiz seçim");
                        break;

                }
                Console.WriteLine("Devam etmek istiyor musunuz ? (e / h)");
                cevap = Console.ReadLine();

            } while (cevap != "h");

            Console.ReadKey();
        }
    }
}
