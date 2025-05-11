using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8Unite2
{
    internal class Makine
    {
        public event EventHandler SicaklikAsildi;
        private Random rnd = new Random();

        public void Calistir()
        {
            while (true)
            {
                int sicaklik = rnd.Next(900, 1101); 
                Console.WriteLine("Sıcaklık: " + sicaklik + " °C");

                if (sicaklik > 1000)
                {
                    SicaklikAsildi?.Invoke(this, EventArgs.Empty); 
                    break;
                }

                System.Threading.Thread.Sleep(1000);
            }
        }

        public void Kapat()
        {
            Console.WriteLine("Makine AŞIRI ISINMA nedeniyle kapatıldı!");
        }
    }
}
