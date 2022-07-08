using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnurAkyıldız191307026Hafta3Ödev3
{
    class Program
    {
        static void birinciyazdır(double i,double j)
        {
            Console.WriteLine("girilen ilk değer =" + i); 
            Console.WriteLine("girilen ikinci değer =" + j);
           
            i = i * i;
            j = j * j;
        }
        static void ikinciyazdır(ref double n,ref double m)
        {
            Console.WriteLine("girilen ilk değer =" + n);
            Console.WriteLine("girilen ikinci değer =" + m);
           
            n = n * n;
            m = m * m;
        }
        static void Main(string[] args)
        {
            double x,y;
            Console.Write("1. double değeri belirleyiniz =");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. double değeri belirleyiniz =");
            y = Convert.ToDouble(Console.ReadLine());
           
            birinciyazdır(x, y);// birinci metota gönderildi ve yazdırıldı farklı değerler olmadıkları görüldü
            Console.WriteLine("metottan dönen değerler =" + x + ", " + y); 
            Console.WriteLine("aynı değerler olur ref kullanmadığımız için");
            
            Console.WriteLine("-----------------------------------");
            ikinciyazdır(ref x, ref y);//ref kullanıldıpı için farklı değerlerle dönüş yapıldı
            Console.WriteLine("metottan dönen değerler =" + x + ", " + y); 
            Console.WriteLine("görüldüğü gibi farklı değerler alır ref kullandığımız için");

            Console.ReadKey();

        }
    }
}
