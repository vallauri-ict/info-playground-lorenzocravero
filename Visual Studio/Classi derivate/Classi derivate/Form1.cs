﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classi_derivate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mostro demone = new Mostro();
            MessageBox.Show(demone.Valore()+" "+demone.Verso());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Mannaro umano = new Mannaro();
            MessageBox.Show(umano.Valore() + " " + umano.Verso());
            umano.Muta();
            MessageBox.Show(umano.Valore() + " " + umano.Verso());
        }
    }
}
