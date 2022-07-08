using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar donanım = new bilgisayar();

            donanım.marka = "Dell G317";
            donanım.islemci = "i7 8750H";
            donanım.ekrankartı = "nvidia Geforce GTX 1050Ti";
            donanım.hdd = "1 TB";
            donanım.ssd = "128 GB";
            donanım.ram = "16 GB";

            Console.WriteLine("bilgisayarımın markası ="+donanım.marka);
            Console.WriteLine("bilgisayarımın işlemcisi ="+donanım.islemci);
            Console.WriteLine("bilgisayarımın ekran kartı ="+donanım.ekrankartı);
            Console.WriteLine("bilgisayarımın hard disk boyutu ="+donanım.hdd);
            Console.WriteLine("bilgisayarımın ssd boyutu ="+donanım.ssd);
            Console.WriteLine("bilgisayarımın ram boyutu ="+donanım.ram);

            Console.ReadKey();
        }
    }
}
