using System;
using System.Collections;
using System.Diagnostics;

namespace string_fonksiyon_ile_process
{
    class Program
    {
        static void Main(string[] args)
        {

            string paragraf = "Raporları taslak olarak son teslim tarihi 12 Haziran 2020, " +
                "Proje raporunun son halinin teslimi jüri sınav günü(30 Haziran 2020'dir)!" +
                "Proje soru ve önerileriniz için: 'yselim@kocaeli.edu.tr' mailine bilgilendirme gönderiniz!" +
                "Duyurular için www.kocaeli.edu.tr sayfasını takip edin!";//277 karakterden oluşur 

            Console.WriteLine("proje kelimesi değişti =");
            string a = paragraf.Replace("Proje", "Proje B");// Proje kelimesi ile Proje B yi yer değiştirir
            Console.WriteLine(a);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("tarih değişti =");
            string b = a.Replace("Haziran 2020", "Mayıs 2021");// haziran 2020 tarihini mayıs 2021 olarak değiştirir
            Console.WriteLine(b);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("harflerin hepsi küçük oldu =");
            string c = b.ToLower();//harflerin hepsini küçük yaptı 
            Console.WriteLine(c);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("tırnak işaretleri silindi =");
            string d = c.Replace("'", " ");// ' işaretini space ile değiştirdi
            Console.WriteLine(d);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("e-posta adresi mevcut mu =");
            int x;
            x = paragraf.IndexOf("@kocaeli.edu.tr");
            if (x > -1)
                Console.WriteLine("e-posta adresi mevcuttur");
            else
                Console.WriteLine("e-posta adresi mevcut değildir");
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("e-posta adresine gitme");
            string e = d.Substring(d.IndexOf("  ") + 2, d.IndexOf(".tr") - d.IndexOf("  ") + 1);//yselim@kocaeli.edu.tr adresini aldık            
            Console.WriteLine(e);
            Process.Start("http://" + e);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("e-posta kullanıcı adı =");
            string f = e.Remove(e.IndexOf("@"), e.IndexOf(".tr") - e.IndexOf("@") + 3);//yselim i bulduk
            Console.WriteLine(f);
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("kelimelere bölme");
            string[] g = d.Split(' ');
            foreach (string i in g)
                Console.WriteLine(i);
            Console.WriteLine("------------------------------------------------------------------------------");

            
           
            Console.ReadKey();

        }//main sonu
    }
}
