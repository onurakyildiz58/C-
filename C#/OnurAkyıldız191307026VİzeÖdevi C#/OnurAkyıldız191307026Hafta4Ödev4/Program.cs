using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnurAkyıldız191307026Hafta4Ödev4
{
    class Program
    {
        static void fonksiyon(int x, double y, long z, char t, byte s, Boolean u)
        {
            Console.WriteLine(x + " değeri =" + x.GetType());
            Console.WriteLine(y + " değeri =" + y.GetType());
            Console.WriteLine(z + " değeri =" + z.GetType());
            Console.WriteLine(t + " değeri =" + t.GetType());
            Console.WriteLine(s + " değeri =" + s.GetType());
            Console.WriteLine(u + " değeri =" + u.GetType());

        }
        static void fonk(ArrayList q)
        {
            foreach (var i in q)
            {
                Console.WriteLine(i + " değerinin tipi =" + i.GetType());
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int a = 41;
            double b = 41.58;
            long c = 999;
            char d = 'B';
            byte e = 8;
            Boolean f = true;
            fonksiyon(a, b, c, d, e, f);

            ArrayList liste = new ArrayList();

            Console.WriteLine("bir değer giriniz bitince H yazınız");
            string cvp = Console.ReadLine();
            object t;
            int x = 0;
            while (cvp != "H")
            {

                try
                {
                    t = Convert.ToInt32(cvp);
                    liste.Add(t);
                    x = 1;
                }
                catch (Exception)
                { }
                if (x != 1)
                {
                    try
                    {
                        t = Convert.ToDouble(cvp);
                        liste.Add(t);
                        x = 2;
                    }
                    catch (Exception)
                    { }
                }
                if (x != 1 && x != 2)
                {
                    try
                    {
                        t = Convert.ToBoolean(cvp);
                        liste.Add(t);
                        x = 3;
                    }
                    catch (Exception)
                    { }
                }
                if (x != 1 && x != 2 && x != 3)
                {
                    try
                    {
                        t = Convert.ToChar(cvp);
                        liste.Add(t);
                        x = 4;
                    }
                    catch (Exception)
                    { }
                }
                             
                if (x != 1 && x != 2 && x != 3 && x != 4)
                {
                    try
                    {
                        t = Convert.ToString(cvp);
                        liste.Add(t);
                    }
                    catch (Exception)
                    { }
                }
                x = 0;
                Console.WriteLine("bir değer giriniz");
                cvp = Console.ReadLine();

            }

            fonk(liste);

            Console.ReadKey();
        }//main sonu
    }
}
