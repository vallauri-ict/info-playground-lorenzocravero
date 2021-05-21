using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_liste
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public int id;
            public string titolo;
            public string autore;
        }

        List<Libro> miaLista = new List<Libro>(); //inizializzazione di una list associata alla struttura
        List<book> listaObject = new List<book>(); //inizializzazione di una lista associata all'object

        int i = 0;
        Dictionary<int,Libro> listaConIndice = new Dictionary<int, Libro>();//inizializzazione di un dizionario 

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            Libro l;

            l.id = Convert.ToInt32(txtID.Text);
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            txtTitolo.Text = "";
            txtAutore.Text = "";
            txtID.Text = "";
            txtTitolo.Focus();
            miaLista.Add(l);
        }

        private void BtnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (var libro in miaLista)
            {
                MessageBox.Show("Titolo: "+libro.titolo+"\nAutore: "+libro.autore);
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            Libro l = miaLista.Find(x => x.titolo == txtFindLibro.Text);
            MessageBox.Show("Il ilbro "+l.titolo+" è dell'autore "+l.autore);
        }

        private void BtnFindAll_Click(object sender, EventArgs e)
        {
            List<Libro> listaAutori = new List<Libro>();
            listaAutori = miaLista.FindAll(x => x.autore == txtFindAutore.Text);
            MessageBox.Show("I libri di "+txtFindAutore.Text+" sono:");
            foreach (var libro in listaAutori)
            {
                MessageBox.Show(libro.titolo);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            book b = new book(txtTitolo.Text, txtAutore.Text, Convert.ToInt32(txtID.Text));
            listaObject.Add(b);

            txtTitolo.Text = "";
            txtAutore.Text = "";
            txtID.Text = "";
            txtTitolo.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (var libro in listaObject)
            {
                MessageBox.Show("Titolo: " + libro.titolo + "\nAutore: " + libro.autore);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            l.id = Convert.ToInt32(txtID.Text);

            listaConIndice.Add(i, l);
            i++;

            txtTitolo.Text = "";
            txtAutore.Text = "";
            txtID.Text = "";
            txtTitolo.Focus();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            foreach (var libro in listaConIndice.Values)
            {
                MessageBox.Show("Titolo: "+libro.titolo+"\nAutore: "+libro.autore);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(txtIndice.Text);
            Libro l = listaConIndice[indice];
            MessageBox.Show("Il libro di indice "+indice+" è\n"+l.titolo+" di "+l.autore);
        }
    }
}
