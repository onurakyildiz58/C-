using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aranan_kelimeyi_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime, aranan;
            Console.Write("kelime yazınız =");
            kelime = Console.ReadLine();
            Console.Write("aranan kelimeyi girin =");
            aranan = Console.ReadLine();
            Console.Write(kelime.IndexOf(aranan));

            Console.ReadKey();
        }
    }
}
