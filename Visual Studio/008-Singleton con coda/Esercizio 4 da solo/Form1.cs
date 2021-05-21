using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_4_da_solo
{
    public partial class Form1 : Form
    {
        public string item;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            item = txtElemento.Text;
            Queue.inserisci(item);
            txtElemento.Text = "";
            txtElemento.Focus();
        }

        private void BtnStampa_Click(object sender, EventArgs e)
        {
            string s = Queue.estrai(item);
            MessageBox.Show(s);
        }
    }
}
