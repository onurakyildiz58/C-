using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnuAkyıldızÖdev3._1.txt
{
    class Program
    {
        static void Metot(int a)
        {
            Console.WriteLine("girdiğiniz sayı ="+a);
        }
        static void Metot(double x, double y)
        {
            double çarpım;
            çarpım = x * y;
            Console.WriteLine(çarpım);
        }
        static void Metot(string ad,string soyad)
        {
            string tamad;
            tamad = ad +" "+ soyad;
            Console.WriteLine(tamad);
        }
        static void Main(string[] args)
        {
            int b;
            Console.Write("lütfen bi sayı giriniz :");
            b = Convert.ToInt32(Console.ReadLine()); 
            Metot(b);
            Console.WriteLine();

            double k, l;
            Console.WriteLine("çarpım yapılacak ondalıklı sayı giriniz");
            Console.Write("sayı 1 :");
            k = Convert.ToDouble(Console.ReadLine());
            Console.Write("sayı 2 :");
            l = Convert.ToDouble(Console.ReadLine());
            Metot(k,l);
            Console.WriteLine();

            string ad, soyad;
            Console.WriteLine("ad ve soyadınızı giriniz ");
            Console.Write("ad :");
            ad = Console.ReadLine();
            Console.Write("soyad :");
            soyad = Console.ReadLine();
            Metot(ad, soyad);

            Console.ReadKey();
        }
    }
}
