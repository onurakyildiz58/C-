using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_fonksiyonları
{
    class Program
    {
        static void Main(string[] args)
        {              
            string yazı = "   onur SAÇI siyah VE /gözleri siyAH              ";
                        
            Console.WriteLine(yazı.Substring(0, 11));// verilen değerlerdeki karakterleri alır ve yazdırır

            Console.WriteLine(yazı.IndexOf('/'));// "/" işateri nerde onu gösterir

            Console.WriteLine(yazı.Trim());// baştaki ve sondaki boşlukları siler
            Console.WriteLine(yazı.TrimEnd());//sondaki boşluğu siler
            Console.WriteLine(yazı.TrimStart());//baştaki boşluğu siler

            Console.WriteLine(yazı.ToLower());// bütün harfleri küçük yapar
            Console.WriteLine(yazı.ToUpper());// bütün harfleri büyük yapar

            Console.WriteLine(yazı.Remove(15));//15. karakterden sonrasını siler
            Console.WriteLine(yazı.Remove(3,17));//3 ve 17 arasını siler

            Console.WriteLine(yazı.Insert(yazı.IndexOf("V"), "naber")); // 10. karakterden sonra naber ekler
          
            Console.ReadKey();
        }
    }
}
