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
    public partial class Figlia : Form
    {
        public TextBox txtdaForm1;
        public TextBox txtACuiInviare;
        public Figlia(TextBox txtForm1)
        {
            InitializeComponent();
            txtdaForm1 = txtForm1;
            txtFiglia.Text = txtdaForm1.Text;
            txtACuiInviare = txtForm1;
        }

        private void btnPassaPapa_Click(object sender, EventArgs e)
        {
            txtACuiInviare.Text = txtFiglia.Text;
        }
    }
}
