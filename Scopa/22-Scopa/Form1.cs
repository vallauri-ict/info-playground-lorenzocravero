using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Scopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mazzo mazzo;

        private void BtnMazzo_Click(object sender, EventArgs e)
        {
            mazzo = new Mazzo();
            MessageBox.Show("Creato nuovo mazzo");
        }

        private void BtnMostra_Click(object sender, EventArgs e)
        {
            foreach (var carta in mazzo.mazzo)
            {
                MessageBox.Show(carta.Valore+" di "+carta.Seme);
            }
        }

        private void BtnEstrai_Click(object sender, EventArgs e)
        {
            Carta estratta;

            estratta = mazzo.Estrai();
            MessageBox.Show("Carta estratta: "+estratta.Valore+" di "+estratta.Seme);
        }

        private void BtnMescola_Click(object sender, EventArgs e)
        {
            mazzo.Mescola();
        }
    }
}
