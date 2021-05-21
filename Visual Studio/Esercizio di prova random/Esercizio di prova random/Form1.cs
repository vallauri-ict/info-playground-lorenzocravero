using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_di_prova_random
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
            ff.Text = "Form figlia";
            if(ff.ShowDialog()==DialogResult.OK)
            {
                txtMainNome.Text = ff.nome;
                txtMainCognome.Text = ff.cognome;
                txtMainEta.Text = ff.eta;
            }
        }

        private void SecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtValore.Text);
            Secondaria fs = new Secondaria(n);
            fs.Text = "Form secondaria";
            fs.Show();
        }
    }
}
