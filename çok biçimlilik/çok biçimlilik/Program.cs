using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çok_biçimlilik
{
    class insan
    {
        public virtual void selam()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("selam!");
        }
    }

    class türk : insan
    {
        public override void selam()
        { 
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("selamın aleyküm!");
           
        }
    }

    class amerikan : insan
    {
        public override void selam()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hİ BİTCH!");
           
        }
    }

    class çinli : insan
    {
        public override void selam()
        { 
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("konniçiva");
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            insan ins = new insan();
            ins.selam();

            türk trk = new türk();
            trk.selam();

            amerikan usa = new amerikan();
            usa.selam();

            çinli çin = new çinli();
            çin.selam();


            Console.ReadKey();
        }
    }
}
