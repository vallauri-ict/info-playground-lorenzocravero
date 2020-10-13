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
    public partial class Form3 : Form
    {
        public int n;
        public Form3(int n)
        {
            InitializeComponent();
            this.n = n+20;
        }

        private void BtnLeggiValore2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valore passato e modificato "+n);
        }
    }
}
