using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3Unite1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 16,
                b = 12,
                c = 10;

            double sonuc1 = a + c / (double)(b - c) * 10;
            Console.WriteLine("Parantezli işlem sonucu: " + sonuc1);
            double sonuc2 = a + c / b - c * 10;
            Console.WriteLine("Parantezsiz işlem sonucu: " + sonuc2);
            double sonuc3 = a + (10 * c) / (double)(b - c);
            Console.WriteLine("Çarpma-bölme yer değiştirdi: " + sonuc3);
            bool pozitifMi = sonuc1 > 0;
            Console.WriteLine("Sonuç pozitif mi? " + pozitifMi);
            bool dogruMu = sonuc1 > 20;
            Console.WriteLine("Sonuç 20'den büyük mü? " + dogruMu);
            Console.ReadLine();

        }
    }
}
