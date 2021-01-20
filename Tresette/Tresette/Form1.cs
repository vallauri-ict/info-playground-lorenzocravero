using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tresette
{
    public partial class Form1 : Form
    {
        MazzoCarte mazzoCarte;
        Carte newCarta;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProponi_Click(object sender, EventArgs e)
        {
            newCarta = new Carte();
            string estratta = newCarta.proponi();
            MessageBox.Show("Estratta: " + estratta);
        }

        private void BtnEstraiPrima_Click(object sender, EventArgs e)
        {
            mazzoCarte = new MazzoCarte();
            Carte aus = mazzoCarte.dammiCarta();
            MessageBox.Show("La prima carta del mazzo è " + aus.VALORE + " di " + aus.SEME);
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            mazzoCarte = new MazzoCarte();
            newCarta = new Carte();
            newCarta.SEME = txtSeme.Text;
            newCarta.VALORE = txtValore.Text;

            mazzoCarte.inserisciCarta(newCarta);
        }

        private void BtnEstrai_Click(object sender, EventArgs e)
        {
            mazzoCarte = new MazzoCarte();
            bool trovata = false;
            foreach (var carta in mazzoCarte.mazzo)
            {
                if (carta.SEME == txtSeme.Text)
                {
                    if (carta.VALORE == txtValore.Text)
                    {
                        trovata = true;
                    }
                }
            }
            if (trovata)
            {
                MessageBox.Show("Carta trovata");
            }
            else
            {
                MessageBox.Show("Carta non trovata");
            }
        }
    }
}
