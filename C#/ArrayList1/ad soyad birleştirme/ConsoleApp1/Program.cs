using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isim birleştirme
{
    class Program
    {
        public static string birlestir(string x, string y)
        {
            return x + " " + y;            
        }
        static void Main(string[] args)
        {
            string ad, soyad, a;
            Console.Write("ad giriniz =");
            ad = Console.ReadLine();
            Console.Write("soyad girin =");
            soyad = Console.ReadLine();
            a=birlestir(ad,soyad);
            
            Console.Write(ad+" kelimesi ile "+soyad+" kelimelerinin birleşmiş hali ="+ a);
           
            Console.ReadKey();
        }
    }
}
