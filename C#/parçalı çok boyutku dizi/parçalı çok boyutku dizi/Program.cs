using System;

namespace parçalı_çok_boyutku_dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][] dizi = new int[3][];
            dizi[0] = new int[3];
            dizi[1] = new int[2];
            dizi[2] = new int[4];

            dizi[0][0] = rnd.Next(20);
            dizi[0][1] = rnd.Next(20);
            dizi[0][2] = rnd.Next(20);

            dizi[1][0] = rnd.Next(20);
            dizi[1][1] = rnd.Next(20);

            dizi[2][0] = rnd.Next(20);
            dizi[2][1] = rnd.Next(20);
            dizi[2][2] = rnd.Next(20);
            dizi[2][3] = rnd.Next(20);

            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi[i].Length; j++)
                {
                    Console.Write(dizi[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
