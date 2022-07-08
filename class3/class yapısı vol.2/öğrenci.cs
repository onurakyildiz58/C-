using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_yapısı_vol._2
{
    class öğrenci
    {
        private string ad;
        private string soyad;
        private int yas;
        private string alan;
       

        public string AD
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }

        public string SOYAD
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
       
        public string ALAN
        {
            get
            {
                return alan;
            }
            set
            {
                alan = value;
            }
        }
       
        public int YAS
        {
            get
            {
                return yas;
            }
            set
            {
                if (value < 6)
                {
                    Console.WriteLine("daha okula başlamamış");
                    yas = value;
                }               
                else
                {
                    yas = value;
                }

            }
        }
       
       
       
    }
}
