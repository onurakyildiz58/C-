using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            uçak uck = new uçak();

            uck.MARKA = "THY";
            uck.KALKIŞ = "istanbul";
            uck.VARIŞ = "ankara";
            uck.AD = "onur";
            uck.SOYAD = "akyıldız";
            uck.YAŞ = 19;
            uck.UÇAKTAKİKONUM = "business class";

            Console.WriteLine("uçak markası ="+ uck.MARKA);
            Console.WriteLine("kalkış yeri ="+ uck.KALKIŞ);
            Console.WriteLine("varış yeri =" + uck.VARIŞ);
            Console.WriteLine("yolcunun ad ve soyadı =" + uck.AD + " " + uck.SOYAD);
            Console.WriteLine("yolcunun yaşı =" + uck.YAŞ);
            Console.WriteLine("yolcunun uçaktaki yeri =" + uck.UÇAKTAKİKONUM);
           
            
            Console.ReadKey();

        }
    }
}