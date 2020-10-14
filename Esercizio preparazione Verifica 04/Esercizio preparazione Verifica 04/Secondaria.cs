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
    public partial class Secondaria : Form
    {
        public string nome = "";
        public string eta = "";
        public Secondaria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nome = "";
            eta = "";
        }
    }
}
