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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void voce1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Items.Add("Aperta voce1");
        }

        private void voce2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Items.Add("Aperta voce2");
        }

        private void voce3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Items.Add("Aperta voce3");
        }
    }
}
