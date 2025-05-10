using System;

namespace Modul4Unite3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 42;
            object kutuluDeger = sayi; 

            int cikarilanDeger = (int)kutuluDeger;

            Console.WriteLine("Orijinal Değer: " + sayi);
            Console.WriteLine("Boxing Sonucu: " + kutuluDeger);
            Console.WriteLine("Unboxing Sonucu: " + cikarilanDeger);

            if (kutuluDeger is int)
            {
                Console.WriteLine("kutuluDeger bir int türüdür.");
            }

            object yazi = "Merhaba";
            string sonuc = yazi as string;

            if (sonuc != null)
            {
                Console.WriteLine("yazi nesnesi string türüne dönüştürüldü: " + sonuc);
            }

            object sayisal = 10;
            string hataliDonusum = sayisal as string;

            if (hataliDonusum == null)
            {
                Console.WriteLine("sayisal değişkeni string'e dönüştürülemedi.");
            }

            Console.ReadKey();
        }
    }
}
