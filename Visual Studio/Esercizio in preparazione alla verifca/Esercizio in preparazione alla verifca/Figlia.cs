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
    public partial class Figlia : Form
    {
        public string nome = "";
        public string cognome = "";
        public string eta = "";
        public Figlia()
        {
            InitializeComponent();
        }

        private void BtnInviaAForm1_Click(object sender, EventArgs e)
        {
            nome = txtNomeChild.Text;
            cognome = txtCognomeChild.Text;
            eta = txtEtaChild.Text;
        }
    }
}
