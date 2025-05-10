using System;

namespace Modul4Unite2
{
    class Program
    {
        static void DegerArtir(ref int deger)
        {
            deger = deger + 1; 
        }
        static void Main(string[] args)
        {
            int sayi = 5;

            Console.WriteLine("Başlangıç Değeri: " + sayi);
            DegerArtir(ref sayi);

            Console.WriteLine("Artırılmış Değer: " + sayi);
            Console.ReadKey(); 
        }
    }
}
