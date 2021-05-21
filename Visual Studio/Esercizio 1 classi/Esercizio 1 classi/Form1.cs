using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_1_classi
{
    public partial class Form1 : Form
    {
        Rectangle r;
        public Form1()
        {
            InitializeComponent();
            r = new Rectangle();
        }

        private void btnCreaRettangolo_Click(object sender, EventArgs e)
        {
            //r.side1 = Convert.ToInt32(txtBase.Text);
            //r.side2 = Convert.ToInt32(txtAltezza.Text);
            //Rectangle t;
            //t = r;
            //if (r.side1 == r.side2)
            //{
            //    MessageBox.Show("Hai creato due quadrati");
            //}
            //else
            //{
            //    MessageBox.Show("Rettangolo 1:\nBase: " + r.side1 + " \nAltezza: " + r.side2);
            //    MessageBox.Show("Rettangolo 2:\nBase: " + t.side1 + " \nAltezza: " + t.side2);
            //}
            r.color = Color.White;
            r = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(r.getSide());

            r = new Rectangle(12);
            r.color = Color.White;
            //r = new Rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(r.getSide());
        }

        private void BtnCreaFattura_Click(object sender, EventArgs e)
        {
            Fatture f = new Fatture();
            MessageBox.Show("Fattura creata!");
            MessageBox.Show("Numero di fattura corrente: " + f.x);
        }

        private void BtnNFattura_Click(object sender, EventArgs e)
        {
            Fatture.visualizza();
        }

        private void BtnClasseStatica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pigreco: "+MiaMath.pi+" \n3*4= "+MiaMath.prodotto(3,4));
        }
    }
}
