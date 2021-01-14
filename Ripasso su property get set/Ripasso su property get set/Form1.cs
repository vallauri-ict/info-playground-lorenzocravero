using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ripasso_su_property_get_set
{
    public partial class Form1 : Form
    {
        private int valore; //l'incapsulamento serve a non rendere visibili all'esterno di una classe una variabile 
        //ma eventualmente renderla utilizzabile mediante funzioni get e set

        public int Valore
        {
            get => valore;
            set => valore = value;
        }

        public int getValore(int val)
        {
            return valore;
        }

        public void setValore(int val)
        {
            if(true)
            {
                valore = val;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
