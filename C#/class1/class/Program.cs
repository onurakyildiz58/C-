using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Ev
    {
        //üye değişkenler
        int kapıNO;
        string mahalleADI;
        string sokakADI;
        int adaADI;
        int blokADI;
       
        //yapıcılar yıkıcılar
        public  Ev()
        {
            Console.WriteLine("yapıcı çalıştı");
            kapıNO = 1;
            mahalleADI = "atatürk";
            sokakADI = "örcün yolu";
            adaADI = 586;
            blokADI = 6;
        }
        public Ev(int kapıNO, string mahalleADI, string sokakADI, int adaADI, int blokADI)
        {
            this.kapıNO = kapıNO;
            this.mahalleADI = mahalleADI;
            this.sokakADI = sokakADI;
            this.adaADI = adaADI;
            this.blokADI = blokADI;
            Console.WriteLine("parametreli yapıcı çalıştı");
        }
        public Ev (Ev e)
        {
            kapıNO = e.kapıNO;
            mahalleADI = e.mahalleADI;
            sokakADI = e.sokakADI;
            adaADI = e.adaADI;
            blokADI = e.blokADI;
            Console.WriteLine("kopya kurucu çalıştı");
        }

        public void metotstaticolmayan()
        {
            Console.WriteLine("static olmayan çalıştı e1 li olan ");
        }
        public static void metotstaticolan()
        {
            Console.WriteLine("static olan metto çalıştı ev olan ");//static olan bi metotun içinde static olmayan bi mettou çağırmazsın ama tem tersi olabilir 
        }

        ~Ev()
        {
            Console.WriteLine("yıkıcı çalıştı");// üç nesne içine yıkıcı çalışır
        }
        static void Main(string[] args)
        {
            //yapıcı metotlar hiç bir değer ataması olmadan değer atanan değerlere 0 null false atayan yapılarar denir "construcktor"
            Ev e1 = new Ev();//default construcktor
            Ev e2 = new Ev(4,"susam","kahve",599, 5);
            Ev e3 = new Ev(e2);

            e1.metoto1();
            Ev.metot2();
        }
    }
}
