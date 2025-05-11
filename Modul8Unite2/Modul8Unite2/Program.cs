using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8Unite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Ürün Sepeti");
            Console.WriteLine("2 - Makine Sıcaklık Kontrolü");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                UrunProgramCalistir();
            }
            else if (secim == "2")
            {
                MakineProgramCalistir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }

            Console.WriteLine("Program sona erdi.");
        }

        static void UrunProgramCalistir()
        {
            Sepet sepet = new Sepet();

            sepet.UrunEklendi += (sender, e) =>
            {
                double toplam = ((Sepet)sender).ToplamTutar();
                Console.WriteLine($"Toplam Tutar: {toplam} TL");
            };

            while (true)
            {
                Console.Write("Ürün Adı (Çıkmak için boş bırak): ");
                string ad = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ad)) break;

                Console.Write("Ürün Fiyatı: ");
                if (double.TryParse(Console.ReadLine(), out double fiyat))
                {
                    Urun urun = new Urun { Ad = ad, Fiyat = fiyat };
                    sepet.Ekle(urun);
                }
                else
                {
                    Console.WriteLine("Geçersiz fiyat.");
                }
            }
        }

        static void MakineProgramCalistir()
        {
            Makine makine = new Makine();

            makine.SicaklikAsildi += (sender, e) =>
            {
                ((Makine)sender).Kapat();
            };

            makine.Calistir();
        }
    }
}
