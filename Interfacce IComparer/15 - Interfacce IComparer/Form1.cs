using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15___Interfacce_IComparer
{
    public partial class Form1 : Form
    {
        Persona[] vet = {new Persona("Luca", "Ariaudo", "Fossano"),
                        new Persona("Samuele","De Toffol","Bra"),
                        new Persona("Andrea","Abbate","Alba"),
                        new Persona("Christian","Gallone","Fossano")};

        public Form1()
        {
            InitializeComponent();
            ShowPersona();
        }

        private void BtnCognome_Click(object sender, EventArgs e)
        {
            Array.Sort(vet, new Persona.ConfrontaCognome());
            ShowPersona();
        }

        private void BtnNome_Click(object sender, EventArgs e)
        {
            Array.Sort(vet, new Persona.ConfrontaNome());
            ShowPersona();
        }

        public void ShowPersona()
        {
            string s = "";
            foreach (var persona in vet)
            {
                s += persona.ToString() + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
