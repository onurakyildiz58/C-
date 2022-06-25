using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aşırı_yüklenme
{
    class Program
    {
        static void fonk()
        {
            Console.WriteLine("bana parametre gelmedi");
        }
       
        static double fonk(double c, double d)
        {
            return c* d;
}
       
        static double fonk(double e)
        {
            return e* e;
        }
       
        static void fonksiyon(params object[] p)//sıbırsız değer alır ve aşırı yüklenme olmaz
        {
           if(p.Length==0)
                Console.WriteLine("değer verilmelidir değersiz çalıştı");
            foreach (var item in p)
            {
                Console.WriteLine(item);
            }
           
        }
        
        static void Main(string[] args)
        {
            int x, y;
            x = 10;
            y = 20;
            fonk();
            Console.WriteLine("int sonuç" + fonk(x, y));
            Console.WriteLine("double sonuç" + fonk(4.5, 1.2));
            Console.WriteLine("double kare sonuç" + fonk(4.7));

            fonksiyon();
            fonksiyon(1,5,"onur");
            fonksiyon(1.4,'d');
            fonksiyon("ali",4.7);

            Console.ReadKey();

        }
    }
}
