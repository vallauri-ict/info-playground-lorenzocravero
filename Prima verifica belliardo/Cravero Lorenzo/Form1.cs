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
    public partial class Form1 : Form
    {
        public string sceltaInterni;
        public string sceltaMacchina;
        public Form1()
        {
            InitializeComponent();
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1(ref sceltaInterni,ref sceltaMacchina);
            f.Text = "Figlia 1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 20);
            f.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figlia2 f = new Figlia2(ref sceltaInterni,ref sceltaMacchina);
            f.Text = "Figlia 2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(215, 20);
            f.Show();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Esci fe = new Esci();
            if (fe.ShowDialog() == DialogResult.OK)
                Close();
        }
    }
}
