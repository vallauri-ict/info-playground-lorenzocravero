using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondoEsDispenseMana_Delegate
{
    public partial class Form1 : Form
    {
        private Counter cnt;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrea_Click(object sender, EventArgs e)
        {
            try
            {
                cnt = new Counter(Convert.ToInt32(txtMaxValue.Text));
                cnt.OverMax += new OverMaxEventHandler(gestioneMaxValue);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void gestioneMaxValue(object sender, OverMaxEventArgs e)
        {
            MessageBox.Show("Raggiunto il valore: "+e.ValoreSoglia);
        }
    }
}
