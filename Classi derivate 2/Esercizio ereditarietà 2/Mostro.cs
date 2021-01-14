using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_ereditarietà_2
{
    public class Mostro
    {
        public string nome;
        public Mostro() :this("Mostro")
        {
            //System.Windows.Forms.MessageBox.Show("secondo");
        }

        public Mostro(string nome)
        {
            //System.Windows.Forms.MessageBox.Show("primo");
            this.nome = nome;
        }

        public void Rivela()
        {
            System.Windows.Forms.MessageBox.Show(nome);
        }
    }
}
