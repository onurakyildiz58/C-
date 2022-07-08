using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string eposta = "yselim@kocaeli.edu.tr";
            Console.WriteLine("Sonuc:" + eposta.Substring(3, 5));
            Console.ReadKey();

        }
    }
}
