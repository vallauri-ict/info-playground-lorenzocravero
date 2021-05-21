using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quaternioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnComplesso_Click(object sender, EventArgs e)
        {
            if(txtReale.Text =="" && txtImmaginario.Text != "")
            {
                Complesso complesso = new Complesso(Convert.ToDouble(txtImmaginario.Text));
                MessageBox.Show(complesso.Modulo().ToString());
            }
            else if(txtReale.Text != "" && txtImmaginario.Text != "")
            {
                Complesso complesso = new Complesso(Convert.ToDouble(txtReale.Text), Convert.ToDouble(txtImmaginario.Text));
                MessageBox.Show(complesso.Modulo().ToString());
            }
            else if(txtReale.Text == "" && txtImmaginario.Text == "")
            {
                Complesso complesso = new Complesso();
                MessageBox.Show(complesso.Modulo().ToString());
            }
            else
            {
                MessageBox.Show("Manca parte immaginaria");
            }
            
        }

        private void BtnQuaternione_Click(object sender, EventArgs e)
        {
            Quaternione quaternione = new Quaternione(Convert.ToDouble((txtReale.Text !="")?(txtReale.Text) : ("0")), Convert.ToDouble((txtImmaginario.Text != "") ? (txtImmaginario.Text) : ("0")), Convert.ToDouble((txtImmaginarioC.Text != "") ? (txtImmaginarioC.Text) : ("0")), Convert.ToDouble((txtImmaginarioD.Text != "") ? (txtImmaginarioD.Text) : ("0")));
            MessageBox.Show(quaternione.Modulo().ToString());
        }
    }
}
