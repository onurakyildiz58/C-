using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnurAkyıldız191307026Hafta2Ödev2
{
    class Program
    {
        public static void yazdir(ArrayList il)
        {
            foreach (var d in il)
            {               
                Console.WriteLine(d);                
            }
        }
        
        static void Main(string[] args)
        {
            ArrayList iller = new ArrayList();
            iller.Add("kocaeli");
            iller.Add("sivas");
            iller.Add("kocaeli");
            iller.Add("aydın");
            iller.Add("kocaeli");
            iller.Add("antalya");
            iller.Add("edirne");
            
            yazdir(iller);
            int x = iller.Count;
            Console.WriteLine("eleman sayısı ="+x);
           
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("5. sıraya marmara eklendi");
            iller.Insert(4, "marmara");
            yazdir(iller);
            int y = iller.Count;
            Console.WriteLine("eleman sayısı ="+y);
           
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("başa adana ili eklendi");
            iller.Insert(0, "adana");
            yazdir(iller);
            int z = iller.Count;
            Console.WriteLine("eleman sayısı =" + z);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("kocaeli var mıdır");
            int e = iller.IndexOf("kocaeli");                                                          
            if(e>0)
                Console.WriteLine("kocaeli vardır");
            else
                Console.WriteLine("kocaeli yoktur");
                  
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("dizi terster yazıldı");
            iller.Reverse();
            yazdir(iller);
            int a = iller.Count;
            Console.WriteLine("eleman sayısı =" +a);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("kaç tane kocaeli vardır ve yerleri nelerdir");
            int q = iller.IndexOf("kocaeli");
            int w = 0;
            while (q > -1)
            {
                Console.WriteLine(q+". sırada bulunur");
                q = iller.IndexOf("kocaeli", q + 1);
                w++;
            }
            Console.WriteLine(w + " tane kocaeli kelimesi vardır");
           
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" 3. ve 5. indisi silelim ");
            iller.RemoveRange(2, 1);
            iller.RemoveRange(3, 1);
            yazdir(iller);
            int b = iller.Count;
            Console.WriteLine("eleman sayısı =" + b);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("yüm dizi silindi");
            iller.Clear();
            yazdir(iller);
            int c = iller.Count;
            Console.WriteLine("eleman sayısı =" + c);

            Console.ReadKey();
        }
    }
}
