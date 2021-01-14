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
    public partial class Secondaria : Form
    {
        public int valore;
        public Secondaria(int n)
        {
            InitializeComponent();
            valore = n;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il valore passato è "+valore);
        }
    }
}
