using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5Unite1
{
    internal class Program
    {

        class Bisiklet
        {
            private int hiz;
            private int vites;
            private int VitesSayisi;

            public Bisiklet()
            {
                hiz = 0;
                vites = 1;
                VitesSayisi = 18;
            }

            public Bisiklet(int vitesSayisi)
            {
                hiz = 0;
                vites = 1;
                VitesSayisi = vitesSayisi;
            }

            public void VitesDegistir(int yeniVites)
            {
                if (yeniVites > 0 && yeniVites <= VitesSayisi)
                {
                    vites = yeniVites;
                }
                else
                {
                    Console.WriteLine("Geçersiz vites değeri!");
                }
            }

            public void Hizlan(int artis)
            {
                hiz += artis;
            }

            public void FrenYap(int azalis)
            {
                hiz -= azalis;
                if (hiz < 0)
                    hiz = 0;
            }

            public void BilgileriYaz()
            {
                Console.WriteLine($"Hız: {hiz}, Vites: {vites}, Vites Sayısı: {VitesSayisi}");
            }

            public void VitesDegeriManuel(int yeniVites)
            {
                vites = yeniVites;
            }

            public void HizDegeriManuel(int yeniHiz)
            {
                hiz = yeniHiz;
            }

            static void Main(string[] args)
            {
                
                Bisiklet bisiklet1 = new Bisiklet(); 
                bisiklet1.Hizlan(10);
                bisiklet1.VitesDegistir(3);
                bisiklet1.FrenYap(2);
                bisiklet1.BilgileriYaz();
                Console.WriteLine("----------------");
                
                Bisiklet bisiklet2 = new Bisiklet(21); 
                bisiklet2.Hizlan(20);
                bisiklet2.VitesDegistir(5);
                bisiklet2.FrenYap(10);
                bisiklet2.BilgileriYaz();

                Console.WriteLine("----------------");

                bisiklet2.VitesDegeriManuel(2);
                bisiklet2.HizDegeriManuel(15);
                bisiklet2.BilgileriYaz();
                Console.ReadLine();
            }
        }
    }
}
