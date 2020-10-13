using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_MultiformConMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ApriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(10);
            f2.Text = "Aperta f2 statica con parametro";
            f2.Show();
        }

        private void ApriForm2DinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Aperta f2b dinamica";
            f2b.Show();
        }
    }
}
