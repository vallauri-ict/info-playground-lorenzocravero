using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_026_Stagisti
{
    public partial class Form1 : Form
    {
        Elenco elencoStudenti;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new Elenco();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Alunno studente;
            if(txtOre.Text.Trim() == "")
            {
                studente = new Alunno(txtNome.Text,txtCognome.Text,txtCitta.Text,cmbClasse.SelectedItem.ToString(),cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString());
            }
            else
            {
                studente = new Stagista(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedItem.ToString(), cmbAzienda.SelectedItem.ToString(), txtOre.Text);
                btnRicerca.Enabled = true;
            }
            elencoStudenti.inserisci(studente);
            elencoStudenti.visualizzaDGV(dgvStudenti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach (Control c in Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if(c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedItem.ToString();
            int ore = elencoStudenti.OreAzienda(azienda);

            if(ore != 0)
            {
                MessageBox.Show("Gli stagisti hanno effettuato "+ ore+" in "+azienda, "information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Non è stata effettuata alcuna ora in "+azienda, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
