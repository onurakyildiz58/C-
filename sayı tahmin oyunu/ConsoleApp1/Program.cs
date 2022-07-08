using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int tahmin, sayac;
                Console.WriteLine("bir tahmin girin =");
                tahmin = Convert.ToInt32(Console.ReadLine());

                Random randomNumbers = new Random();
                int rastgele = randomNumbers.Next(0, 101);

                sayac = 0;
              

                while (tahmin != rastgele)
                {
                    if (tahmin > rastgele)
                    {
                        Console.WriteLine("daha küçük değer gir");
                    }
                    else
                    {
                        Console.WriteLine("daha büyük değer gir");
                    }

                    sayac++;

                    Console.WriteLine("bir tahmin girin =");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(sayac + " defada bildiniz");

                Console.WriteLine("tebrikler bildiniz");
            }

            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }
            Console.ReadKey();
            
        }
    }
}
