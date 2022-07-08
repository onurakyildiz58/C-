using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_yapısı_vol._3
{
    class Program
    {
        static void Main(string[] args)
        {
            emlak ev = new emlak();

            Console.Write("    ");
            Console.Write("semti giriniz =");
            ev.SEMT = Console.ReadLine();

            Console.Write("    ");
            Console.Write("oda sayını giriniz =");
            ev.ODA = Convert.ToInt32(Console.ReadLine());
            int x = ev.ODA;

            Console.Write("    ");
            Console.Write("salon sayını giriniz =");
            ev.SALON = Convert.ToInt32(Console.ReadLine());
            int y = ev.SALON;

            Console.Write("    ");
            Console.Write("türünü giriniz villa mı apartman mı =");
            ev.TÜR = Console.ReadLine();

            Console.Write("    ");
            Console.Write("apartmansa kaçıncı katta villa ise kaç katlı =");
            ev.KAT = Convert.ToInt32(Console.ReadLine());

            Console.Write("    ");
            Console.Write("amerikan mutkak mı normal mutfak mı =");
            ev.MUTFAKYAPISI = Console.ReadLine();

            Console.Write("    ");
            Console.Write("kaç m^2 =");
            ev.ALAN = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("evin bulundupu semt =" + ev.SEMT);
            Console.WriteLine("evin aship olduğu oda sayısı =" + ev.ODA);
            Console.WriteLine("evin aship olduğu salon sayısı =" + ev.SALON);
            Console.Write("kaç + kaç ="); Console.WriteLine(x - y + " + " +y);
            Console.WriteLine("evin ne olduğu villa mı apartman mı =" + ev.TÜR);
            Console.WriteLine("kaç katlı olduğu =" + ev.KAT);
            Console.WriteLine("mutkaf yapısı =" + ev.MUTFAKYAPISI);
            Console.WriteLine("kaç metre kare alanı var =" + ev.ALAN);


            Console.ReadKey();
        }
    }
}
