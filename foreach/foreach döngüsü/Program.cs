using System;

namespace foreach_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "kocaeli", "bursa", "çanakkale", "antalya", "sivas" };

            foreach(string i in sehirler)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
