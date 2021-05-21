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
    public partial class Esci : Form
    {
        public Esci()
        {
            InitializeComponent();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
