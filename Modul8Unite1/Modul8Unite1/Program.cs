using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8Unite1
{
    internal class Program
    {
        public delegate void SiralaDelegate(ref string[] kelimeler);
        static void Main(string[] args)
        {
            string[] sozcukler = { "elma", "armut", "muz" };
            Console.WriteLine("Orijinal Dizi:");
            DiziYazdir(sozcukler);
            SiralaDelegate sirala = AZSirala;
            sirala(ref sozcukler);
            Console.WriteLine("\nA-Z Sıralı:");
            DiziYazdir(sozcukler);
            sirala += ZASirala;
            Console.WriteLine("\nÇoklu çağrım başlatılıyor (A-Z sonra Z-A):");
            sirala(ref sozcukler);
            Console.WriteLine("\nSon Durum:");
            DiziYazdir(sozcukler);
            Console.ReadLine();
        }
        static void AZSirala(ref string[] kelimeler)
        {
            Array.Sort(kelimeler);
            Console.WriteLine("A-Z sıralandı.");
        }
        static void ZASirala(ref string[] kelimeler)
        {
            Array.Sort(kelimeler);
            Array.Reverse(kelimeler);
            Console.WriteLine("Z-A sıralandı.");
        }
        static void DiziYazdir(string[] kelimeler)
        {
            foreach (var kelime in kelimeler)
            {
                Console.Write(kelime + " ");
            }
            Console.WriteLine();
        }
    }
}
