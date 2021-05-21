using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cravero_Lorenzo
{
    public partial class Figlia2 : Form
    {
        public string scelta1 = "";
        public string scelta2 = "";
        public Figlia2(ref string sceltaInterni,ref string sceltaMacchina)
        {
            InitializeComponent();
            scelta1 = sceltaInterni;
            scelta2 = sceltaMacchina;
            MessageBox.Show("Hai selezionato "+sceltaMacchina+" con interni in "+sceltaInterni);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtScelta.Text = "Hai selezionato " + scelta1 + " con interni in " + scelta1;
        }
    }
}
