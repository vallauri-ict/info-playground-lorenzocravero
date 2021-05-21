using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_di_prova_sulle_classi
{
    public partial class Form1 : Form
    {
        Rectangle r;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrea_Click(object sender, EventArgs e)
        {
            if((txtAltezza.Text=="") ||(txtBase.Text==""))
            {
                MessageBox.Show("Inserisci entrambe le dimensioni");
            }
            else
            {
                r = new Rectangle();
                //r.b = Convert.ToInt32(txtBase.Text);
                //r.h = Convert.ToInt32(txtAltezza.Text);
                MessageBox.Show("Rettangolo creato\nBase: "+r.b+"\nAltezza: "+r.h);
                //r = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
                btnArea.Enabled = true;
                btnPerimetro.Enabled = true;
            }
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L'area è uguale a "+Rectangle.calcolaArea(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text)));
        }

        private void BtnPerimetro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il perimetro è uguale a "+Rectangle.calcolaPerimetro(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtBase.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnArea.Enabled = false;
            btnPerimetro.Enabled = false;
        }
    }
}
