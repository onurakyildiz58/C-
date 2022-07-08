using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191307026OnurAkyıldızHafta12Ödev9
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Random rast = new Random();  
            
            for (int k = 0; k < 10; k++)
            {
                int x,y,z,t;
            
                
                x = rast.Next(0, 10);
                Console.Write(x + "=");
                y = 0;
                z = 0;
                t = 0;
          
                for (int i = 1; i <= x; i++)
                   {
                      if (x % i == 0)
                       {
                           y++;                         
                       }
                   }

                if (y == 2)
                    {
                       Console.WriteLine("sayı asaldır");
                       z = x;
                     
                    }
                else
                    {
                       Console.WriteLine("sayı asal değildir");
                       
                    }
                t = t + z;
                Console.WriteLine("asal olan sayıların toplamı ="+t);
            }
                
                Console.ReadKey();        
        }
    }
}
