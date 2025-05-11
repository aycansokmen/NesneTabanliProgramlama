using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7Unite1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci birOgrenci = new Ogrenci("Aycan SÖKMEN");
            Console.WriteLine("Adı");
            Console.WriteLine("{0}", birOgrenci.Ad);
            Console.WriteLine("Boyu");
            Console.WriteLine("{0}", birOgrenci.Boy);
            Console.WriteLine("Kilosu");
            Console.WriteLine("{0}", birOgrenci.Kilo);

            Console.WriteLine("\n");
            Daire daire = new Daire(3.0);
            Console.WriteLine("Kürenin Alanı :");
            Console.WriteLine("{0}", daire.Alan());

        }
    }
    class Insan
    {
        public double Boy, Kilo;
        public string Ad;
        public Insan(string ad)
        {
            Ad = ad;
            Boy = 0.45;
            Kilo = 3.5;
        }
        public void Buyu()
        {
            Boy += 0.5;
            Kilo += 0.5;
        }
    }
    class Ogrenci : Insan
    {
        public Ogrenci(string ad) : base(ad)
        {
        }
        new public void Buyu()
        {
            Boy += 1.5;
            Kilo += 1.5;
        }
    }
    public class Sekil
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Sekil() { }

        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Alan()
        {
            return x * y;
        }
    }

    public class Daire : Sekil
    {
        public Daire(double r) : base(r, 0) { }

        public override double Alan()
        {
            return PI * x * x;
        }
    }

    public class Kure : Sekil
    {
        public Kure(double r) : base(r, 0) { }

        public override double Alan()
        {
            return 4 * PI * x * x;
        }
    }

}
