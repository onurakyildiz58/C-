using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class yolcu
    {
        private int yaş;
        private string ad;
        private string soyad;
        private string uçaktakikonum;
           //kapsülleme yapıldı
        public int YAŞ
        {
            get { return yaş; }
            set { yaş = Math.Abs(value); }
        }

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public string UÇAKTAKİKONUM
        {
            get { return uçaktakikonum; }
            set { uçaktakikonum = value.ToUpper(); }
        }
    }
}
