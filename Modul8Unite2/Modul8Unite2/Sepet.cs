using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8Unite2
{
    internal class Sepet
    {
        public List<Urun> Urunler = new List<Urun>();
        public event EventHandler UrunEklendi; 

        public void Ekle(Urun urun)
        {
            Urunler.Add(urun);
            UrunEklendi?.Invoke(this, EventArgs.Empty); 
        }

        public double ToplamTutar()
        {
            double toplam = 0;
            foreach (var u in Urunler)
                toplam += u.Fiyat;
            return toplam;
        }
    }
}

