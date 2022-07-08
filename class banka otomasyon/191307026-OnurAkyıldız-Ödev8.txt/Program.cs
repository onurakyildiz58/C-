using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldız_Ödev8.txt
{
    class KrediHesap
    {
        public static string adısoyadı;
        public static int bakiye;
        public static int limit;
        public static int müşterinumarası;
        public static int kartsayısı=0;

        
        public static void HesapAc(int müşterinum,string ad,int bakiye,int limit)
        {
            KrediHesap.kartsayısı = KrediHesap.kartsayısı + 1;
            KrediHesap.müşterinumarası = müşterinum;
            KrediHesap.adısoyadı = ad;
            KrediHesap.bakiye = bakiye;
            KrediHesap.limit = limit;
            KrediHesap.Yazdir(müşterinumarası,adısoyadı,bakiye,limit);
        }
        public static void ParaCek(int müşterinum, string ad, int para)
        {
            if (KrediHesap.limit < para)
            {
                Console.WriteLine("maalesesef çekmek istediğiniz tutar limitinizden fazladır");
            }
            else
            {
                if (KrediHesap.bakiye >= para)
                {
                    KrediHesap.bakiye = KrediHesap.bakiye - para;
                }
                else if (KrediHesap.bakiye < para)
                {
                    int ana = KrediHesap.bakiye + KrediHesap.limit;
                    KrediHesap.limit = ana - para;

                    KrediHesap.bakiye = 0;
                }
                KrediHesap.Yazdir(müşterinum, ad, bakiye, limit);
            }
        }
        public static void ParaYatir(int müşterinum, string ad, int para)
        {
            KrediHesap.bakiye = KrediHesap.bakiye + para;
            KrediHesap.Yazdir(müşterinum, ad, bakiye, limit);
        }
        public static void ToplamKartSayisi()
        {
            Console.WriteLine("kredi karti sayısı : "+KrediHesap.kartsayısı);
        }
        public static void Yazdir(int müşnum, string adı,int bakiye,int limit)
        {
            Console.WriteLine("müşteri no : "+müşnum);
            Console.WriteLine("müşteri adı soyadı : "+adı);
            Console.WriteLine("kart bakiyesi : "+bakiye);
            Console.WriteLine("kart limiti : "+limit);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************MÜŞTERİ BİR************************************");
            KrediHesap kredikart = new KrediHesap();
            Console.Write("müşteri adını giriniz : ");
            string ad = Console.ReadLine();
            Console.Write("banka kartına ait bakiye ve limit bilgilerini yazınız");
            Console.WriteLine();
            Console.Write("bakiye : ");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            Console.Write("limit : ");
            int limit = Convert.ToInt32(Console.ReadLine());
            KrediHesap.HesapAc(1,ad,bakiye,limit);

            Console.WriteLine("***********************************************************************************");
            Console.Write("çekmek istediğiniz tutarı yazınız : ");
            int para1 = Convert.ToInt32(Console.ReadLine());
            KrediHesap.ParaCek(1,ad,para1);

            Console.WriteLine("***********************************************************************************");
            Console.Write("yatırmak istediğiniz tutarı giriniz : ");
            int para2 = Convert.ToInt32(Console.ReadLine());
            KrediHesap.ParaYatir(1,ad,para2);
            KrediHesap.ToplamKartSayisi();

            Console.WriteLine("************************************MÜŞTERİ İKİ************************************");
            KrediHesap kredikart1 = new KrediHesap();
            Console.Write("müşteri adını giriniz : ");
            string ad1 = Console.ReadLine();
            Console.Write("banka kartına ait bakiye ve limit bilgilerini yazınız");
            Console.WriteLine();
            Console.Write("bakiye : ");
            int bakiye1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("limit : ");
            int limit1 = Convert.ToInt32(Console.ReadLine());
            KrediHesap.HesapAc(2, ad1, bakiye1, limit1);

            Console.WriteLine("***********************************************************************************");
            Console.Write("çekmek istediğiniz tutarı yazınız : ");
            int para3 = Convert.ToInt32(Console.ReadLine());
            KrediHesap.ParaCek(2, ad1, para3);

            Console.WriteLine("***********************************************************************************");
            Console.Write("yatırmak istediğiniz tutarı giriniz : ");
            int para4 = Convert.ToInt32(Console.ReadLine());
            KrediHesap.ParaYatir(2, ad1, para4);
            KrediHesap.ToplamKartSayisi();


            Console.ReadKey();
        }
    }
}
