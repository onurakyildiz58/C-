using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_yapısı_vol._3
{
    class emlak
    {
        private string semt;
        private int oda;
        private int salon;
        private string tür;
        private int kat;
        private string mutfakyapısı;
        private double alan;

        public string SEMT
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public int SALON
        {
            get { return salon; }
            set { salon = Math.Abs(value); }
        }

        public int ODA
        {
            get { return oda; }
            set { oda = Math.Abs(value); }          
        }

        public string TÜR
        {
            get { return tür; }
            set { tür = value; }
        }

        public int KAT
        {
            get { return kat; }
            set { kat = Math.Abs(value); }
        }

        public string MUTFAKYAPISI
        {
            get { return mutfakyapısı; }
            set { mutfakyapısı = value.ToLower(); }
        }

        public double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
