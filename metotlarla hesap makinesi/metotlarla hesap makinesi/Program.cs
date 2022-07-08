using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarla_hesap_makinesi
{
    class Program
    {
       

        public static double islem(double s1, double s2, string op)
        {
            if (op == "+")
            {
                return  s1 + s2;
            }
            else if (op == "-")
            {
                return  s1 - s2;
            }
            else if (op == "*")
            {
                return  s1 * s2;
            }
            else
            {
                return  s1 / s2;
            }
        }
        static void Main(string[] args)
        {
            int x, y;
            string op;
            double sonuc;
            Console.Write("ilk sayıyı girin =");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı girin =");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("işlem belirleyiniz =");
            op = Convert.ToString(Console.ReadLine());

            sonuc=islem(x, y, op);

            Console.Write("sonuc = " + sonuc);

            Console.ReadKey();
        }
        
    }
}
