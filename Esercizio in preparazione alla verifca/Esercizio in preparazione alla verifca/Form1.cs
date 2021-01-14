using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_in_preparazione_alla_verifca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figlia ff = new Figlia();
            if(ff.ShowDialog()==DialogResult.OK)
            {
                txtNomeMain.Text = ff.nome;
                txtCognomeMain.Text = ff.cognome;
                txtEtaMain.Text = ff.eta;
            }
        }

        private void SecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtPassa.Text);
            Secondaria fs = new Secondaria(n);
            fs.Show();
        }

        private void BtnModificaMain_Click(object sender, EventArgs e)
        {

        }

        private void TerzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Terza ft = new Terza(txtModificaMain);
            ft.Show();
        }
    }
}
