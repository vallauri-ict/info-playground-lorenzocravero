using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct dizionario
        {
            public int key;
            public string nomeArticolo;
        }

        int i = 0;
        Dictionary<int, dizionario> catalogo = new Dictionary<int, dizionario>();

        private void TxtCarica_Click(object sender, EventArgs e)
        {
            dizionario d;
            d.key = Convert.ToInt32(txtKey.Text);
            d.nomeArticolo = txtValue.Text;

            catalogo.Add(i++, d);
            MessageBox.Show("Inserimento effettuato");
            lblElementi.Text = i.ToString();

            txtKey.Text = "";
            txtValue.Text = "";
            txtKey.Focus();
        }

        private void BtnVisual_Click(object sender, EventArgs e)
        {
            foreach (var d in catalogo.Values)
            {
                MessageBox.Show("Chiave: "+d.key+"\nArticolo: "+d.nomeArticolo);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dizionario d;
            d.nomeArticolo = "";
            foreach (var art in catalogo.Values)
            {
                if(art.key==Convert.ToInt32(txtRicerca.Text))
                {
                    d.nomeArticolo = art.nomeArticolo;
                }
            }
            if(d.nomeArticolo=="")
            {
                MessageBox.Show("L'articolo cercato è\n" + d.nomeArticolo);
            }
            else
            {
                MessageBox.Show("L'articolo cercato non esiste");
            }
        }
    }
}
