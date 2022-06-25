using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class Program
    {
        public static void faktöriyel()
        { 
            int deger,c;
            c = 1;
            Console.Write("bir değer belirleyin =");
            deger = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= deger; i++)
            {
                c = c * i;
            }
        Console.WriteLine("girilen değerin faktöriyeli ="+deger+"! ="+c);
        } 

        
        static void Main(string[] args)
        {
            Console.WriteLine("metotlarla faktöriyel");                       
            faktöriyel();
         
            Console.ReadKey();
        }
    }
}
