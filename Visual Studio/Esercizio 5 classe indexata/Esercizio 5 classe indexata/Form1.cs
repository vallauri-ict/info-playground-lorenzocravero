using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_5_classe_indexata
{
    public partial class Form1 : Form
    {
        MyIndexClass indexVet;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrea_Click(object sender, EventArgs e)
        {
            indexVet = new MyIndexClass(Convert.ToInt32(txtElementi.Text));
            MessageBox.Show("Classe creata");
            for (int i = 0; i < Convert.ToInt32(txtElementi.Text)-1; i++)
            {
                indexVet[i] = i.ToString();
            }
        }

        private void BtnVisual_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < indexVet.length(); i++)
            {
                s += indexVet[i] + " - ";
            }
            MessageBox.Show("Elementi: "+s);
        }
    }
}
