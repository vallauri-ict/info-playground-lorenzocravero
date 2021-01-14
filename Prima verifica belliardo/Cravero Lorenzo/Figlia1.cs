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
    public partial class Figlia1 : Form
    {
        public Figlia1(ref string sceltaInterni,ref string sceltaMacchina)
        {
            InitializeComponent();
            string interni="";
            if (chkPelle.Checked == true)
                interni = "pelle";
            else
            {
                if (chkStoffa.Checked == true)
                    interni = "stoffa";
            }
            sceltaInterni = interni;
            sceltaMacchina = comboBox1.Text;
        }
    }
}
