using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3Unite3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //int sayi1 = Convert.ToInt32(textBox1.Text);
            //int sayi2 = Convert.ToInt32(textBox2.Text);
            //int toplam = 0;
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam += i;
            //}
            //textBoxSonuc.Text = toplam.ToString();


            //int sayi1 = Convert.ToInt32(textBox1.Text);
            //int sayi2 = Convert.ToInt32(textBox2.Text);
            //int toplam = 0;
            //int i = sayi1;
            //while (i <= sayi2)
            //{
            //    toplam += i;
            //    i++;
            //}
            //textBoxSonuc.Text = toplam.ToString();


            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = 0;
            int i = sayi1;
            while (i <= sayi2)
            {
                toplam += i;
                i++;
            }
            textBoxSonuc.Text = toplam.ToString();
        }
    }
}
