using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_aşırı_yüklenme_
{
    class Program
    {
        static void fonk(ref int t)
        {
            Console.WriteLine("value "+t);
            t = 500;
        }
        
        static void Main(string[] args)
        {
            int v = 100;
            fonk(ref v);// değer ataması var ise ref yok ise out kullanılır 
            Console.WriteLine("main "+v);

            Console.ReadKey();
        }
    }
}
