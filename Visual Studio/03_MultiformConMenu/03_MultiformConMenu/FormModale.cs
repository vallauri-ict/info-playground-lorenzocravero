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
    public partial class FormModale : Form
    {
        public string nome = "";
        public string eta = "";
        public FormModale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome = txtMod1.Text;
            eta = txtMod2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nome = "";
            eta = "";
        }
    }
}
