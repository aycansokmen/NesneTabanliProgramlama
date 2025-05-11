using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7Unite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Ogretmen ogretmen = new Ogretmen();

            ogrenci.Buyu();
            ogretmen.Buyu();

            ogrenci.Oku();
            ogretmen.Oku();

            Console.ReadLine();
        }
    }
}
