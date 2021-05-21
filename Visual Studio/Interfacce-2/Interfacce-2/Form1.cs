using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfacce_2
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
        }

        public void ShowPerson()
        {
            string s = "";
            foreach (var persona in vet)
            {
                s += persona.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            Array.Sort(vet);
            ShowPerson();
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            ShowPerson();
        }
    }
}
