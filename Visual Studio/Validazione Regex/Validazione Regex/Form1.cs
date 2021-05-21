using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Validazione_Regex
{
    public partial class Form1 : Form
    {
        public Regex rgx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string pattern = @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$";
            if(Regex.IsMatch(txtEspressione.Text,pattern))
            {
                MessageBox.Show("Targa valida");
            }
            else
            {
                txtEspressione.Text = "";
                MessageBox.Show("Targa non valida");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            rgx = new Regex(@"^[a-zA-Z]{8}[0-9]{3}[- ! @]$");
            if(rgx.IsMatch(txtEspressione.Text))
            {
                MessageBox.Show("Password valida");
            }
            else
            {
                txtEspressione.Text="";
                MessageBox.Show("Password non valida");
            }
        }
    }
}
