using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modul1Unite2
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Topla_Click_1(object sender, RoutedEventArgs e)
        {
            //double sayi1 = Convert.ToDouble(TextBox1.Text);
            //double sayi2 = Convert.ToDouble(TextBox2.Text);
            //TextBox3.Text = (sayi1 + sayi2).ToString();
            int a = Int16.Parse(TextBox1.Text);
            int b = Int16.Parse(TextBox2.Text);
            TextBox3.Text = (a + b).ToString();
        }

        private void Çıkar_Click(object sender, RoutedEventArgs e)
        {
            //double sayi1 = Convert.ToDouble(TextBox1.Text);
            //double sayi2 = Convert.ToDouble(TextBox2.Text);
            //TextBox3.Text = (sayi1 - sayi2).ToString();
            int a = Int16.Parse(TextBox1.Text);
            int b = Int16.Parse(TextBox2.Text);
            TextBox3.Text = (a - b).ToString();
        }

        private void Çarp_Click(object sender, RoutedEventArgs e)
        {
            //double sayi1 = Convert.ToDouble(TextBox1.Text);
            //double sayi2 = Convert.ToDouble(TextBox2.Text);
            //TextBox3.Text = (sayi1 * sayi2).ToString();
            int a = Int16.Parse(TextBox1.Text);
            int b = Int16.Parse(TextBox2.Text);
            TextBox3.Text = (a * b).ToString();
        }

        private void Böl_Click(object sender, RoutedEventArgs e)
        {
            //double sayi1 = Convert.ToDouble(TextBox1.Text);
            //double sayi2 = Convert.ToDouble(TextBox2.Text);
            //if (sayi2 != 0)
            //    TextBox3.Text = (sayi1 / sayi2).ToString();
            //else
            //    MessageBox.Show("Sıfıra bölme hatası!");
            int a = Int16.Parse(TextBox1.Text);
            int b = Int16.Parse(TextBox2.Text);
            TextBox3.Text = (a / b).ToString();

        }
    }
}
