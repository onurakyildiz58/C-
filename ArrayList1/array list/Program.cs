using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arylst = new ArrayList();
            arylst.Add(1.5);
            arylst.Add("onur");
            arylst.Add(51);
            arylst.Add(true);


            arylst.Reverse();
            foreach (var k in arylst)
            {
                Console.WriteLine(k);
            }


            foreach (var i in arylst)
            {
                Console.WriteLine("Türü: {0,2} değeri: {0,5}", i.GetType(), i);
            }
           

            Console.ReadKey();


        }
    }
}
