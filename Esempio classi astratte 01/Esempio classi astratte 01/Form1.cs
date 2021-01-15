using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esempio_classi_astratte_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStampa_Click(object sender, EventArgs e)
        {
            ElencoStudenti elStud = new ElencoStudenti();
            elStud.print();
            MessageBox.Show(elStud.stampa);
            
        }
    }
}
