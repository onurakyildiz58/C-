using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ile_dizi
{
    class Program
    {
        public static void yazdir(Array dizi)
        {
            Console.WriteLine("**********************************************");
            for (int i = 0; i < dizi.Length; i++)
            {
                //dizinin uzunluğuna kadar değerleri alıp ekrana yazdı
                Console.WriteLine("eleman ="+ dizi.GetValue(i));
            }
        }
        static void Main(string[] args)
        {
            Array dizi= Array.CreateInstance(typeof(int), 10);
            //diziye değer atandı
            dizi.SetValue(10, 0);
            dizi.SetValue(58, 1);
            dizi.SetValue(82, 2);
            dizi.SetValue(3, 3);
            dizi.SetValue(17, 4);
            dizi.SetValue(1, 5);
            dizi.SetValue(72, 6);
            dizi.SetValue(67, 7);
            dizi.SetValue(75, 8);
            dizi.SetValue(28, 9);
            // yazdır adlı metota gidildi ve bu değerler yazdırıldı
            yazdir(dizi);
            
            Array.Sort(dizi);//diziyi sıralar küçükten büyüğe a dan z ye
            yazdir(dizi);

            Array.Reverse(dizi);// diziyi yers çevirir
            yazdir(dizi);

            Array.Clear(dizi, 0, 2);//dizide belirlenen aralığı siler
            yazdir(dizi);

            //aranan değeri bulma
            int aranan = 67;           
            int yer =Array.IndexOf(dizi, aranan);
            if (yer < 0) 
            {
                Console.WriteLine(aranan+" değer dizide bulunmuyor ");
            }
            else
            {
                Console.WriteLine(aranan + " değeri dizide "+(yer+1)+ ". sırada");
            }
            Console.ReadKey();       
        }
    }
}
