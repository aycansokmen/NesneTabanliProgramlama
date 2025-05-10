using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3Unite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Lütfen görmek istediğiniz kat numarasını giriniz (0-3): ");
            //int kat = Convert.ToInt32(Console.ReadLine());

            //if (kat == 0)
            //{
            //    Console.WriteLine("Zemin Kat: Danışma, Güvenlik, Kafeterya");
            //}
            //else if (kat == 1)
            //{
            //    Console.WriteLine("1. Kat: Müdür Odası, Öğretmenler Odası");
            //}
            //else if (kat == 2)
            //{
            //    Console.WriteLine("2. Kat: Laboratuvarlar, Kütüphane");
            //}
            //else if (kat == 3)
            //{
            //    Console.WriteLine("3. Kat: Sınıflar, Etüt Salonu");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen 0-3 arasında bir kat numarası giriniz...");
            //}

            //Console.ReadLine();
            Console.Write("Lütfen görmek istediğiniz kat numarasını giriniz (0-3): ");
            int kat = Convert.ToInt32(Console.ReadLine());

            switch (kat)
            {
                case 0:
                    Console.WriteLine("Zemin Kat: Danışma, Güvenlik, Kafeterya");
                    break;
                case 1:
                    Console.WriteLine("1. Kat: Müdür Odası, Öğretmenler Odası");
                    break;
                case 2:
                    Console.WriteLine("2. Kat: Laboratuvarlar, Kütüphane");
                    break;
                case 3:
                    Console.WriteLine("3. Kat: Sınıflar, Etüt Salonu");
                    break;
                default:
                    Console.WriteLine("Lütfen 0-3 arasında bir kat numarası giriniz...");
                    break;
            }

            Console.ReadLine();
        }
    }
    
}
