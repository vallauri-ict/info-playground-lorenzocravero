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
    public partial class Secondaria : Form
    {
        public int val;
        public Secondaria(int n)
        {
            InitializeComponent();
            this.val = n;
        }

        private void BtnLeggiValore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il valore passato è "+val);
        }
    }
}
