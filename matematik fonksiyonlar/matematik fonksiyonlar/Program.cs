using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematik_fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //mutlak değer
            Console.WriteLine("+++mutlak değer+++");
            int sayi;
            Console.Write("bir sayı giriniz= ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girilen sayının mutlak hali =" + Math.Abs(sayi));


            //üste alta yuvarlama
            Console.WriteLine("+++yuvarlama+++");
            double x;
            Console.Write("bir sayı giriniz =");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("sayının üste yuvarlanmış hali =" + Math.Ceiling(x));
            Console.WriteLine("sayının alta yuvarlanmış hali =" + Math.Floor(x));

            //üs alma 
            Console.WriteLine("+++üs alma+++");
            int taban, us;
            Console.Write("bir sayı giriniz =");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("üs belirleyin =");
            us = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girilen sayının üse göre katı =" + Math.Pow(taban, us));

            //kare kök
            Console.WriteLine("+++kare kök+++");
            int y;
            Console.Write("bir sayı giriniz =");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girilen sayının kare kökü =" + Math.Sqrt(y));

            //kosinüs ve sinüs
            Console.WriteLine("+++cos ve sin+++");
            double u;
            Console.Write("bir derce giriniz =");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("girilen derecedeki cos değeri =" + Math.Cos(u));
            Console.WriteLine("girilen derecedeki sin değeri =" + Math.Sin(u));

            //büyük küçük
            Console.WriteLine("+++büyük küçük+++");
            int sayı1, sayı2;
            Console.Write("birinci sayıyı giriniz =");
            sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı belirleyin =");
            sayı2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("büyük sayı =" + Math.Max(sayı1, sayı2));
            Console.WriteLine("küçük sayı =" + Math.Min(sayı1, sayı2));

            Console.ReadKey();
        }
    }
}
