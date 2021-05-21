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
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void BtnFigliaDiChi_Click(object sender, EventArgs e)
        {
            if (Owner.Text!=null)
            {
                MessageBox.Show("Questa form è figlia di "+Owner.Name);
            }
        }
    }
}
