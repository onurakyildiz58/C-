using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaman_fonksiyonları
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman;
            zaman = DateTime.Now;
            Console.WriteLine("tarih ve saat = {0}", zaman);//saniyeli olarak tarihi ve saat verir

            int gün = zaman.Day;
            int ay = zaman.Month;
            int yıl = zaman.Year;
            DayOfWeek haftanıngünü = zaman.DayOfWeek;
            Console.WriteLine("gün = {0} ", gün);
            Console.WriteLine("ay = {0} ", ay);
            Console.WriteLine("yıl = {0} ", yıl);
            Console.WriteLine("haftanıngünü = {0} ",haftanıngünü);

            Console.WriteLine("tarih = {0:d} ",zaman);// kısaca tarıihi sayılı olarak verir
            Console.WriteLine("tarih = {0:D} ", zaman);// uzun uzuna ay ismi ile veririr
            Console.WriteLine("tam tarih = {0:F} ", zaman);//saniyesine kadar verir
            Console.WriteLine("tam tarih = {0:f} ", zaman);// saniye hariç gün ay yıl saat dakikayı verir
            Console.WriteLine("saat = {0:t} ", zaman);//saati verir
            Console.WriteLine("saat = {0:T} ", zaman);// saati saniye ile birlikte verir

            Console.ReadKey();

        }
    }
}
 