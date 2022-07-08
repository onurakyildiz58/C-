using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int x;              
            Random rastgele = new Random();
            Array dizi = Array.CreateInstance(typeof(int), 10);
            for (int i = 0; i < 10; i++)
            {
               
                x = rastgele.Next(0, 10);
                dizi.SetValue(x, i);
                
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(dizi.GetValue(j));
            }
           
            Console.ReadKey();
        }
    }
}
