﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_3_classi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreaClasse_Click(object sender, EventArgs e)
        {
            EsSingleton s = EsSingleton.GetEsSingleton(Convert.ToInt32(txtValore.Text));
            MessageBox.Show("Valore di s: "+s.val);
            EsSingleton s1 = EsSingleton.GetEsSingleton(0);
            MessageBox.Show("Valore di s1: "+s1.val);
        }
    }
}
