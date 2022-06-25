using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldızÖdev6._2.txt
{
    class Şekil
    {
        public Şekil(int z)
        {
            Console.WriteLine("tek parametreli kurucu çalıştı");
            Console.WriteLine("bu bir noktadır ve değeri : "+z);
        }
        public Şekil(int x,int y)
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("çift parametreli kurucu çalıştı");
            int alan = x * y;
            int çevre = 2 * (x + y);
            if (x==y)
            {
                Console.WriteLine("bu bir karedir ve");
                Console.WriteLine("alan : "+alan);
                Console.WriteLine("çevresi : "+çevre);
            }
            else
            {
                Console.WriteLine("bu bir dikdörtgendir ve");
                Console.WriteLine("alan : " + alan);
                Console.WriteLine("çevresi : " + çevre);
            }
        }
        public Şekil(int a,int b,int c)
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("üç parametreli kurucu çalıştı");
            Console.WriteLine("bu bir 3 boyutlu cisimdir");
            int hacim = a * b * c;
            if (a==b)
            {
                if (b==c)
                {
                    Console.WriteLine("bu bir küptür ve ");
                    Console.WriteLine("hacim : "+hacim);
                }
                else
                {
                    Console.WriteLine("bu bir kare prizmadır ve");
                    Console.WriteLine("hacim : " + hacim);
                }
            }
            else
            {
                Console.WriteLine("bu bir dikdörtgen prizmadır ve");
                Console.WriteLine("hacim : " + hacim);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int q, w, e, r, t, y;
            Console.Write("bi değer giriniz : ");
            q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("iki kenar için iki değer giriniz : ");
            Console.Write("kenar 1:");
            w= Convert.ToInt32(Console.ReadLine());
            Console.Write("kenar 2:");
            e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üç kenar için 3 tane değer giriniz : ");
            Console.Write("kenar 1:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("kenar 2:");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("kenar 3:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************");

            Şekil ş1 = new Şekil(q);
            Şekil ş2 = new Şekil(w,e);
            Şekil ş3 = new Şekil(r,t,y);

            Console.ReadKey();
        }
    }
}
