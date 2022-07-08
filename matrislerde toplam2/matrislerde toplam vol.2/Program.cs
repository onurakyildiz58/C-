using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrislerde_toplam_vol._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //elle diziye değer girme ve boyutunu istediğin gibi belirleme
            int satır, sutun;
            Console.Write("satır giriniz =");
            satır = Convert.ToInt32(Console.ReadLine());
            Console.Write("sütun giriniz =");
            sutun = Convert.ToInt32(Console.ReadLine());
            int[,] dizi = new int[satır, sutun];

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("dizinin {0} satırının {1} sutunundaki değeri =", i + 1, j + 1);
                    dizi[i, j] = Convert.ToInt32(Console.ReadLine());
                   
                }  
               
            }

            for (int k = 0; k < satır; k++)
            {
                for (int l = 0; l < sutun; l++)
                {
                    Console.Write(" {0} ",dizi[k,l]);
                }
                Console.WriteLine();
            }

            

            Console.ReadKey();
        }
    }
}

