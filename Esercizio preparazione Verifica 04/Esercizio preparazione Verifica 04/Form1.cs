using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_preparazione_Verifica_04
{
    public partial class Form1 : Form
    {
        public string testoMain = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tasto con funzione estetica");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tasto con funzione estetica");
        }

        private void newSecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secondaria fs = new Secondaria();
            if(fs.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("Nome: "+fs.nome);
                MessageBox.Show("Età: "+fs.eta);
            }
            else
            {
                MessageBox.Show("Premuto annulla");
            }
        }

        private void btnModificaMain_Click(object sender, EventArgs e)
        {
            testoMain = txtModificaMain.Text;
        }

        private void figliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRicevi ff = new btnRicevi();
            if (ff.ShowDialog() == DialogResult.OK)
            {
                txtModificaMain.Text = ff.testoFiglia;
            }
            else
            {
                txtModificaMain.Text = "";
            }
        }

        private void mDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI fmdi = new MDI();
            fmdi.Show();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Esci fe = new Esci();
            if(fe.ShowDialog()==DialogResult.OK)
            {
                Close();
            }
        }
    }
}
