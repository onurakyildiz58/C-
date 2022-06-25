using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldız_Ödev7.txt
{
    class Cokgen
    {
        public int yükseklik;
        public int taban1;
        public int taban2;

        public static void AlanHesapla(int taban1,int taban2,int h, int yarıçap)
        {
            Console.WriteLine("şekilin adını giriniz");
            string şekil = Console.ReadLine();
            if (şekil == "daire")
            {
                Daire.alan(yarıçap);
            }
            else if (şekil == "üçgen")
            {
                Ucgen.alan(taban1, taban2, h);
            }
        }
        public static void CevreHesapla(int taban1, int taban2, int h, int yarıçap)
        {
            Console.WriteLine("şekilin adını giriniz");
            string şekil = Console.ReadLine();
            if (şekil=="daire")
            {
                Daire.çevre(yarıçap);
            }
            else if(şekil=="üçgen")
            {
                Ucgen.çevre(taban1, taban2, h);
            }
        }
    }
    class Ucgen : Cokgen
    {
        public Ucgen()
        {
            Console.WriteLine("Üçgen kurucu metodu çalıştı");
        }
        public static void çevre(int taban1, int taban2, int h)
        {
            Console.WriteLine("pisagor teoremi : ((taban1*taban1)+(taban2*taban2))^(1/2)");
            int pisagor = (taban1 * taban1 + taban2 * taban2);
            double hipo = Math.Sqrt(pisagor);
            Console.WriteLine("çevre formülü : ((taban1+h)*2)+((taban2+h)*2)+((pisagor+h)*2)");
            double çevre = ((taban1 + h) * 2) + ((taban2 + h) * 2) + ((hipo + h) * 2);
            Console.WriteLine("üçgen prizma çevre : " + çevre);
        }
        public static void alan(int taban1, int taban2, int h)
        {
            Console.WriteLine("alan formülü : (taban1*taban2/2)*h");
            int alan = (taban1 * taban2 / 2) * h;
            Console.WriteLine("üçgen prizma alan = " + alan);
        }
    }
    class Daire : Cokgen
    {
        public Daire()
        {
            Console.WriteLine("Daire kurucu metodu çalıştı");
        }
        public static void çevre(int yarıçap)
        {
            Console.WriteLine("dairenin çevresi formülü : 2*pi*yarıçap");
            double PI = 3.1415926535897931;
            double çevre = 2 * yarıçap * PI;
            Console.WriteLine("daire çevresi : " + çevre);
        }
        public static void alan(int yarıçap)
        {
            Console.WriteLine("dairenin çevresi formülü : pi*r*r");
            double PI = 3.1415926535897931;
            double alan = PI*yarıçap*yarıçap;
            Console.WriteLine("daire alanı : " + alan);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //kaynak:
            //https://www.srdrylmz.com/tag/c-sinif-turetme/
            //https://www.srdrylmz.com/c-kalitim/
            Cokgen çokgen = new Cokgen();
            Ucgen üçgen = new Ucgen();
            Daire daire = new Daire();

            Console.WriteLine("üçgen prizma taban ölçüleri : ");
            Console.WriteLine("taban 1 : 3");
            üçgen.taban1 = 3;
            Console.WriteLine("taban 2 : 4");
            üçgen.taban2 = 4;
            Console.WriteLine("üçgen prizma yüksekliği : 10");
            üçgen.yükseklik = 10;
            

            Console.WriteLine("daire çeklimiz için yarı çap(r) ölçüleri : ");
            Console.WriteLine("yarı çap : 4");
            daire.taban1 = 4;
            Daire.AlanHesapla(üçgen.taban1, üçgen.taban2, üçgen.yükseklik, daire.taban1);
            Daire.CevreHesapla(üçgen.taban1, üçgen.taban2, üçgen.yükseklik, daire.taban1);
            Ucgen.AlanHesapla(üçgen.taban1, üçgen.taban2, üçgen.yükseklik, daire.taban1);
            Ucgen.CevreHesapla(üçgen.taban1, üçgen.taban2, üçgen.yükseklik, daire.taban1);

            Console.ReadKey();
        }
    }
}
