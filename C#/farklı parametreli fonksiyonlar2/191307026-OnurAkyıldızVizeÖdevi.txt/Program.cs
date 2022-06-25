using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldızVizeÖdevi.txt
{
    class Öğrenci
    {
        public string adsoyad;
        public string bölüm;
        public int tcno;
        public string cinsiyet;
        public string[] ders;
        public int[] notlar;
        public double başarınotu;
        public Öğrenci()
        {
            Console.WriteLine("parametresiz kurucu çalıştı");
            string adsoyad;
            string bölüm;
            int tcno;
            string cinsiyet;
            string[] ders;
            int[] notlar;
            double başarınotu;
        }
        public Öğrenci(string bölüm)
        {
            this.bölüm = bölüm;
            Console.WriteLine("tek parametreli kurucu çalıştı");
        }
        public Öğrenci(string adsoyad, string cinsiyet)
        {
            Console.WriteLine("iki parametreli kurucu çalıştı");
            this.adsoyad = adsoyad;
            this.cinsiyet = cinsiyet;
        }
        public Öğrenci(Öğrenci x)
        {
            adsoyad = x.adsoyad;
            bölüm = x.bölüm;
            tcno = x.tcno;
            cinsiyet = x.cinsiyet;
            ders = x.ders;
            notlar = x.notlar;
            başarınotu = x.başarınotu;
        }
        ~Öğrenci()
        {
            Console.WriteLine("yıkıcı metot çalıştı");
        }
        public static double ortalama1(int[] notlar1, string[] dersler)
        {
            double toplam = notlar1[0] + notlar1[1];
            double sonuç1 = toplam / 2;
            Console.WriteLine(dersler[0] + " dersi için öğrencinin ortalamsı : " + sonuç1);
            return sonuç1;
        }
        public static double ortalama2(int[] notlar2, string[] dersler)
        {
            double toplam = notlar2[0] + notlar2[1];
            double sonuç2 = toplam / 2;
            Console.WriteLine(dersler[1] + " dersi için öğrencinin ortalamsı : " + sonuç2);
            return sonuç2;
        }
        public static double ortalama3(int[] notlar3, string[] dersler)
        {
            double toplam = notlar3[0] + notlar3[1];
            double sonuç3 = toplam / 2;
            Console.WriteLine(dersler[2]+" dersi için öğrencinin ortalamsı : " + sonuç3);
            return sonuç3;
        }
        public static void öğrencikaydet(string adsoyad, string bölüm, string cinsiyet, int tcno)
        {
            Console.WriteLine("öğrencinin adı soyadı : " + adsoyad);
            Console.WriteLine("öğrencinin bölümü : " + bölüm);
            Console.WriteLine("öğrencinin cinsiyeti : " + cinsiyet);
            Console.WriteLine("öğrencinin tcnosu : " + tcno);
        }
        public static void yazdır(int[] notlar1, int[] notlar2, int[] notlar3, string[] dersler,string adsoyad, string bölüm, string cinsiyet, int tcno)
        {
            double a = ortalama1(notlar1, dersler);
            double b = ortalama2(notlar2, dersler);
            double c = ortalama3(notlar3, dersler);
            Console.WriteLine("öğrenci bir için başarı notu : " + (a + b + c) / 3);
            öğrencikaydet(adsoyad, bölüm, cinsiyet, tcno);
        }
        static void Main(string[] args)
        {
            string[] tümdersler = {"matematik","fizik","algoritma","difransiyel","lineer","lab","ingilizce","edebiyat","inkılap","python" };
            Öğrenci öğr1 = new Öğrenci();//parametresiz
            Öğrenci öğr2 = new Öğrenci("bilişim sistemleri mühendisliği");//tek parametreli
            Öğrenci öğr3 = new Öğrenci("özgür mert","erkek");//çift parametreli
            Öğrenci öğr4 = new Öğrenci(öğr3);//kopya yapıcı metot 

            Random rnd = new Random();
            Random rndders = new Random();
            Console.WriteLine("----------------------------------ÖĞRENCİ BİR----------------------------------");
            Console.Write("öğrenci ad ve soyadını giriniz : ");
            öğr1.adsoyad = Console.ReadLine();
            Console.Write("öğrenci bölümünü giriniz : ");
            öğr1.bölüm = Console.ReadLine();
            Console.Write("öğrenci tcnosunu giriniz : ");
            öğr1.tcno = Convert.ToInt32(Console.ReadLine());
            Console.Write("öğrenci cinsiyetini giriniz : ");
            öğr1.cinsiyet = Console.ReadLine();

            string[] dersler = new string[3];
            for (int i = 0; i < 3; i++)
            {
                dersler[i] = tümdersler[rndders.Next(0,9)];
                Console.WriteLine(i + 1 + ". dersi : "+ dersler[i]);   
            }

            Console.WriteLine("******************************");
            int[] notlar1 = new int[2];
            Console.WriteLine(dersler[0] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {
                notlar1[j] = rnd.Next(40, 80);
                Console.WriteLine(j + 1 + ". sınav notu : "+ notlar1[j]);
            }

            Console.WriteLine("******************************");
            int[] notlar2 = new int[2];
            Console.WriteLine(dersler[1] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {                
                notlar2[j] = rnd.Next(40, 80);
                Console.WriteLine(j + 1 + ". sınav notu : " + notlar2[j]);               
            }

            Console.WriteLine("******************************");
            int[] notlar3 = new int[2];
            Console.WriteLine(dersler[2] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {
                notlar3[j] = rnd.Next(40, 80);
                Console.WriteLine(j + 1 + ". sınav notu : "+ notlar3[j]);              
            }
            Console.WriteLine("******************************");
            yazdır(notlar1, notlar2, notlar3, dersler, öğr1.adsoyad, öğr1.bölüm, öğr1.cinsiyet, öğr1.tcno);

            Console.WriteLine("----------------------------------ÖĞRENCİ İKİ----------------------------------");

            öğr2.adsoyad = "ahmet çam";
            öğr2.cinsiyet = "erkek";
            öğr2.tcno = 51486;
            string[] dersler1 = new string[3];
            for (int i = 0; i < 3; i++)
            {
                dersler1[i] = tümdersler[rndders.Next(0, 9)];
                Console.WriteLine(i + 1 + ". dersi : "+ dersler1[i]); 
            }

            Console.WriteLine("******************************");
            int[] notlar11 = new int[2];
            Console.WriteLine(dersler1[0] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {
                notlar11[j] = rnd.Next(40, 80);
                Console.WriteLine(j + 1 + ". sınav notu : " + notlar11[j]);
            }

            Console.WriteLine("******************************");
            int[] notlar22 = new int[2];
            Console.WriteLine(dersler1[1] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {
                notlar22[j] = rnd.Next(40, 80);
                Console.WriteLine(j + 1 + ". sınav notu : "+ notlar22[j]);
            }

            Console.WriteLine("******************************");
            int[] notlar33 = new int[2];
            Console.WriteLine(dersler1[2] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {
                notlar33[j] = rnd.Next(40, 80);
                Console.WriteLine(j + 1 + ". sınav notu : "+ notlar33[j]);
            }
            Console.WriteLine("******************************");
            yazdır(notlar11, notlar22, notlar33, dersler1, öğr2.adsoyad, öğr2.bölüm, öğr2.cinsiyet, öğr2.tcno);

            Console.WriteLine("----------------------------------ÖĞRENCİ üç----------------------------------");
            öğr3.bölüm = "işletme";
            öğr3.tcno = 32498;
            string[] dersler2 = new string[3];
            for (int i = 0; i < 3; i++)
            { 
                dersler2[i] = tümdersler[rndders.Next(0, 9)];
                Console.WriteLine(i + 1 + ". dersi : " + dersler2[i]);
            }

            Console.WriteLine("******************************");
            int[] notlar111 = new int[2];
            Console.WriteLine(dersler2[0] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {
                 notlar111[j] = rnd.Next(40, 80);
                 Console.WriteLine(j + 1 + ". sınav notu : "+ notlar111[j]);
            }

            Console.WriteLine("******************************");
            int[] notlar222 = new int[2];
            Console.WriteLine(dersler2[1] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {
                notlar222[j] = rnd.Next(40, 80); 
                Console.WriteLine(j + 1 + ". sınav notu : " + notlar222[j]);
            }

            Console.WriteLine("******************************");
            int[] notlar333 = new int[2];
            Console.WriteLine(dersler2[2] + " dersi için ");
            for (int j = 0; j < 2; j++)
            {
                notlar333[j] = rnd.Next(40, 80);
                Console.WriteLine(j + 1 + ". sınav notu : "+ notlar333[j]);
            }
            Console.WriteLine("******************************");
            yazdır(notlar111, notlar222, notlar333, dersler2, öğr3.adsoyad, öğr3.bölüm, öğr3.cinsiyet, öğr3.tcno);

            Console.WriteLine("----------------------------------ÖĞRENCİ dört(kopya)----------------------------------");

            yazdır(notlar111, notlar222, notlar333, dersler2, öğr4.adsoyad, öğr4.bölüm, öğr4.cinsiyet, öğr4.tcno);

            Console.ReadKey();
            /*kaynaklar
             * https://www.yazilimkodlama.com/programlama/c-siniflar-yapici-metot-constructor-kullanimi/
             * https://caylakyazilimci.com/post/yapici-ve-yikici-metotlar
             * */
        }
    }
}
