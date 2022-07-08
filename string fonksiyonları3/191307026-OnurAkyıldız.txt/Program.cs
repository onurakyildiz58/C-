using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026_OnurAkyıldız.txt
{
    class Program
    {
        static void Main(string[] args)
        {
            String mail,cümle;
            Console.WriteLine("*******************************1.KISIM*******************************");
            Console.Write("Email gir:");
            mail = Console.ReadLine();
            
            string[] domain = mail.Split('@');//substring ile yaparken hata aldım bende split ile yaptım saçma oldu ama işe yaradı
            Console.WriteLine("kullanıcı adı:"+domain[0]);
            Console.WriteLine("domain:"+domain[1]);

            Console.WriteLine("*******************************2.KISIM*******************************");
            Console.WriteLine("Lütfen bir cümle giriniz :");
            cümle = Console.ReadLine();
            String[] böl = cümle.Split(' ');
            foreach (var item in böl)
            {
                Console.WriteLine("dönüş :"+item);
            }

            Console.ReadKey();
        }
    }
}
