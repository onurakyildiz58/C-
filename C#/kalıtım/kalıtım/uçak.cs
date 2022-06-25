using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class uçak:yolcu //:yolcu dediğimiz zaman kalıtım yapıp class programda ucak sınıfında gözükmeyen ad soyad gibi elemanları görebileceğiz
    {
        private string marka;
        private string kalkış;
        private string varış;

      // kapsülleme yapıldı 
        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }

        public string KALKIŞ
        {
            get { return kalkış; }
            set { kalkış = value.ToUpper(); }
        }

        public string VARIŞ
        {
            get { return varış; }
            set { varış = value.ToUpper(); }
        }

    }
}
