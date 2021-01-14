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
    public partial class Figlia : Form
    {
        public string nome = "";
        public string cognome = "";
        public string eta = "";
        public Figlia()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            nome = "";
            cognome = "";
            eta = "";
        }

        private void BtnInvia_Click(object sender, EventArgs e)
        {
            nome = txtFigliaNome.Text;
            cognome = txtFigliaCognome.Text;
            eta = txtFigliaEta.Text;
        }
    }
}
