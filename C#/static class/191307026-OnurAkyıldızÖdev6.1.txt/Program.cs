using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldızÖdev6._1.txt
{
    static class matematik
    {
        public static int topla(params int[] sayılar)
        {
            int topla = 0;
            for (int i = 0; i < sayılar.Length; i++)
            {
                topla = topla + sayılar[i];
            }
            return topla;
        } 
    }
    class ogrenci
    {
        public static string ad="onur akyıldız";
        public int numara;
        public string bölüm;

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir sınıf içerisindeki static olmayan metotlara ve özelliklere o 
             * sınıftan oluşturduğumuz nesneler üzerinden erişiriz. Static olan 
             * metotlara ve özelliklere ise nesne oluşturmadan sınıf adı ile erişiriz.
             * 
             * Static sınıflardan nesne oluşturulamaz. (new Matematik(); YANLIŞ)
             * Static sınıf türünden referanslar oluşturulamaz. (Matematik m; YANLIŞ)
             * Static sınıfların içinde static olmayan metot yada değişken tanımlanamaz.
             * Static sınıflarda kalıtım yoktur.
             * 
             * Oluşturduğumuz sınıf içerisinde sadece static metotlar ve değişkenler
             * bulunuyorsa sınıfı static olarak tanımlayabiliriz. Sınıfların static 
             * olarak tanımlanması bir zorunluluk değildir sadece okunabilirliği arttıran 
             * bir yaklaşımdır.
             * 
             * Matematik sınıfının üye elemanları static olduğu
             * için sınıfı da static olarak bildirdik. Matematik sınıfının static olduğunu 
             * gören bir programcı, sınıf içerisinde sadece static elemanların 
             * bulunduğunu anlayacaktır.
             * 
             * 
             */
            Console.WriteLine("öğrenci adı soyadı : "+ ogrenci.ad);

            ogrenci öğr = new ogrenci();
            Console.Write("öğrencinin bölümünü giriniz :");
            öğr.bölüm = Console.ReadLine();
            Console.Write("öğrencinin numarasını giriniz :");
            öğr.numara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("öğrencinin numarası : "+öğr.numara);
            Console.WriteLine("öğrencinin bölümü : " + öğr.bölüm);

            Console.WriteLine("****************************************************");
            Console.WriteLine(matematik.topla(128, 134, 13, 12, 100, 72));

            Console.ReadKey();
            /*kaynakça:
             * https://www.srdrylmz.com/c-static-elemanlar-siniflar/
             *
             */
        }
    }
}
