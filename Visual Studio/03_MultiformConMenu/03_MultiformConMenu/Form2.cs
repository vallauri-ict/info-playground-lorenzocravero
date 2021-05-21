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
    public partial class Form2 : Form
    {
        public int n;
        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnValore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il valore passato è "+n);
        }

        private void BtnFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia ff = new FormFiglia();
            this.AddOwnedForm(ff);
            ff.Text = "Aperta form figlia";
            ff.Show();
        }

        private void BtnPassaParametro_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(n);
            f3.Text = "Aperta f3 con parametro di form 1";
            f3.Show();
        }
    }
}
