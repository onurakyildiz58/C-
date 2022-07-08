using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_yapısı_vol._2
{
    class Program
    {
        static void Main(string[] args)
        {
            öğrenci kisi = new öğrenci();
           
            Console.Write("öğrenci adı gir =");
            kisi.AD = Console.ReadLine();
          
            Console.Write("öğrenci soyadı gir =");
            kisi.SOYAD = Console.ReadLine();
          
            Console.Write("öğrenci hangi alanda okuyor =");
            kisi.ALAN = Console.ReadLine();
            
            Console.Write("öğrencinin yaşını giriniz =");
            kisi.YAS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("ad =" + kisi.AD);
            Console.WriteLine("soyad =" + kisi.SOYAD);
            Console.WriteLine("alan =" + kisi.ALAN);
            Console.WriteLine("yaş =" + kisi.YAS);          
        

            Console.ReadKey();
        }
    }
}
