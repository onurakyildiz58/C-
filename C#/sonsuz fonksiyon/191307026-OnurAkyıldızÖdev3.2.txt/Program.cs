using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldızÖdev3._2.txt
{
    class Program
    {
        public static int Toplam(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("değer verilmelidir değersiz çalıştı");
            }
            var toplam = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                toplam += numbers[i];
            }

            return toplam;
        }
        static void Main(string[] args)
        {
            var toplam = Toplam();
            Console.WriteLine("toplam: " + toplam);
            toplam = Toplam(5);
            Console.WriteLine("toplam: " + toplam);
            toplam = Toplam(5,10);
            Console.WriteLine("toplam: " + toplam);
            toplam = Toplam(5,10,15);
            Console.WriteLine("toplam: " + toplam);
            toplam = Toplam(5, 10,15,20);
            Console.WriteLine("toplam: " + toplam);
            toplam = Toplam(5, 10, 15,20,25);
            Console.WriteLine("toplam: " + toplam);

            Console.ReadKey();
        }
    }
}
