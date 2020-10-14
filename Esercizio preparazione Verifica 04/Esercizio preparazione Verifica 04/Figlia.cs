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
    public partial class btnRicevi : Form
    {
        public string testoFiglia;
        public btnRicevi()
        {
            InitializeComponent();
        }

        private void btnModificaFiglia_Click(object sender, EventArgs e)
        {
            testoFiglia = txtModificaFiglia.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            if(main.ShowDialog()==DialogResult.OK)
            {
                txtModificaFiglia.Text = main.testoMain;
            }
        }
    }
}
