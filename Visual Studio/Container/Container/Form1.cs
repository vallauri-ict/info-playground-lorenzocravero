using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Container
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Containers
        {
            public int codice;
            public int peso;
            public int tara;
        }
        Stack<Containers> pila = new Stack<Containers>();

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            Containers container;
            container.codice = Convert.ToInt32(textBox1.Text);
            container.peso = Convert.ToInt32(textBox2.Text);
            container.tara = Convert.ToInt32(textBox3.Text);

            //aggiungo il record alla pila
            pila.Push(container);
            MessageBox.Show("Elemento inserito nella pila");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void BtnEstrai_Click(object sender, EventArgs e)
        {
            Containers estratto = pila.Pop();
            try
            {
                MessageBox.Show("Codice: " + estratto.codice + "\nPeso: " + estratto.peso + "\nTara: " + estratto.tara);
            }
            catch (Exception)
            {
                MessageBox.Show("Pila vuota");
            }
        }
    }
}
