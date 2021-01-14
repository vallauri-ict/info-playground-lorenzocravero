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
    public partial class Terza : Form
    {
        public TextBox txtDaInviare;
        public TextBox txt1;
        public Terza(TextBox txt1)
        {
            InitializeComponent();
            textBox1.Text = txt1.Text;
            txtDaInviare = txt1;
        }

        private void BtnModificaTerza_Click(object sender, EventArgs e)
        {
            txtDaInviare.Text = textBox1.Text;
        }
    }
}
