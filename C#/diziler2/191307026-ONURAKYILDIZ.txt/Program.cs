using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_ONURAKYILDIZ.txt
{
    class Program
    {
        static void yenidizi(int[] dizi,int size)
        {
            Random rnd = new Random();
            int newsize = size / 2;
            for (int i = 0; i < newsize; i++)
            {
                dizi[i] = rnd.Next(10);
            }
            Console.Write("ikinci dizi :");
            for (int j = 0; j < newsize; j++)
            {
                Console.Write(" "+dizi[j]);
            }
            Console.WriteLine();
            Topla(dizi, newsize);
        }
        static void Topla(int[] dizi, int boyut)
        {
            int toplam = 0;
            for (int i = 0; i < boyut; i++)
            {
                toplam = toplam + dizi[i];
            }
            Console.Write("toplam ="+toplam);
        }
        static void Main(string[] args)
        {
            int boyut;
            Console.Write("lütfen diziye boyut giriniz :");
            boyut = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[boyut];
            for (int i = 0; i < boyut; i++)
            {
                dizi[i] = i + 1;
            }
            Console.Write("ilk dizi :");
            for (int j = 0; j < boyut; j++)
            {
                Console.Write(" "+dizi[j]);
            }
            Console.WriteLine();
            yenidizi(dizi,boyut);

            Console.ReadKey();
        }
    }
}
