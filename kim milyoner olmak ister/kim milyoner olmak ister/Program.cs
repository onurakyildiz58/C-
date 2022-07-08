using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kim_milyoner_olmak_ister
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" ***********************************************");
            Console.Write(" YARIŞMAYA HOŞGELDİNİZ ");
            Console.WriteLine("************************************************");
            Console.Title = "BİLGİ YARIŞMASI ";
          
           //yarışmacı k aydı alındı
            string ad, soyad;
            int yaş;
            Console.Write("adınızı giriniz =");
            ad= Console.ReadLine();
            Console.Write("soyadınızı giriniz =");
            soyad = Console.ReadLine();
            Console.Write("yaşınızı giriniz =");
            yaş = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**** YARIŞMACI ****");
            Console.WriteLine(yaş+" yaşında olan "+ad+" "+soyad+"'a başarılar dileriz");
            Console.WriteLine(" HER YANITTAN SONRA ENTER TUŞUNA BASIN!");
            Console.WriteLine(" HER CEVABI BÜYÜK HARFLERLE YAZIN!");
            Console.WriteLine(" BAŞLAMAK İÇİN ENTRA BASIN!");
            Console.ReadLine();

            int doğru, yanlış, para;
            string  c1;
            doğru = 0;
            yanlış = 0;
            para = 0;
            //********************************
            Console.WriteLine("SORU -1-");
            Console.WriteLine("Cumhuriyet hangi yılda kurulmuştur?");
            Console.Write(" A-1920\n B-1923\n C-1924\n D-1921\n E-1922\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1=="B")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para +"TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran "+para+"TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -2-");
            Console.WriteLine("Ayşe'nin 5 kız kardeşlerdir bunlar cici, cucu, çuçu, çiço'dur 5 kardeşin adi nedir?");
            Console.Write(" A-Ahmet\n B-Betül\n C-Ayşe\n D-Çuço\n E-Zeynep\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "C")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -3-");
            Console.WriteLine("");
            Console.Write(" A-\n B-\n C-\n D-\n E-\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -4-");
            Console.WriteLine("");
            Console.Write(" A-\n B-\n C-\n D-\n E-\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -5-");
            Console.WriteLine("");
            Console.Write(" A-\n B-\n C-\n D-\n E-\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -6-");
            Console.WriteLine("");
            Console.Write(" A-\n B-\n C-\n D-\n E-\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -7-");
            Console.WriteLine("");
            Console.Write(" A-\n B-\n C-\n D-\n E-\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -8-");
            Console.WriteLine("");
            Console.Write(" A-\n B-\n C-\n D-\n E-\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -9-");
            Console.WriteLine("");
            Console.Write(" A-\n B-\n C-\n D-\n E-\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            Console.WriteLine("SORU -10-");
            Console.WriteLine("");
            Console.Write(" A-\n B-\n C-\n D-\n E-\n CEVAP =");
            c1 = Console.ReadLine();
            if (c1 == "")
            {
                doğru = doğru + 1;
                para = para + 1000;
                Console.WriteLine("tebrikler doğru bildiniz paranız " + para + "TL'dir bi sonraki soru için entera basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                para = para - 500;
                Console.WriteLine("maalesef bilemedin parandan 500TL eksildi yani paran " + para + "TL'dir bi sonraki soru için entera bas!");
                Console.ReadLine();
            }
            //********************************
            int net;
            net = doğru - (yanlış / 4);
            Console.WriteLine("doğru sayınız ="+doğru);
            Console.WriteLine("yanlış sayınız ="+yanlış);
            Console.WriteLine("net sayınız ="+net);
            Console.WriteLine("kazandığınız para ="+para);
            Console.ReadKey();
        }
    }
}
