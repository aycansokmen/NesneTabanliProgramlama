﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul2Unite1
{
    public partial class Form1 : Form
    {
        enum Gunler
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gunListe = Enum.GetNames(typeof(Gunler));
            foreach (string gun in gunListe)
            {
                comboBox1.Items.Add(gun);
            }
        }
    }
}
