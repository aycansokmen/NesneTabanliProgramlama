using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3Unite4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                    throw new ArgumentNullException("Sayı boş bırakılamaz!");

                int sayi = int.Parse(textBox1.Text);

                if (sayi < 0)
                    throw new Exception("Negatif sayıların faktöriyeli hesaplanamaz.");

                checked 
                {
                    long sonuc = 1;
                    for (int i = 1; i <= sayi; i++)
                    {
                        sonuc *= i;
                    }
                    textBox2.Text = sonuc.ToString();
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Çok büyük bir sayı girdiniz!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
