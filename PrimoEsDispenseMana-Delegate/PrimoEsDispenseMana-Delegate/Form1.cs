using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimoEsDispenseMana_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            GestoreSalvataggio gest = new GestoreSalvataggio();
            gest.salvataggioEseguito += new SalvataggioEseguitoEventHandler(miaFunzione);
            gest.salvataggioEseguito += new SalvataggioEseguitoEventHandler(miaFunzione2);
            gest.SalvaSuFile(5);
        }

        private void miaFunzione(int id)
        {
            MessageBox.Show("Elemento "+id+" salvato correttamente");
        }

        private void miaFunzione2(int id)
        {
            MessageBox.Show("Secondo gestore di event");
        }
    }
}
