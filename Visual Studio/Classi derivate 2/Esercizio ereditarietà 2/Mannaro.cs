using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_ereditarietà_2
{
    public class Mannaro : Mostro
    {
        new public string nome;
        public Mannaro(): base()
        {
            //System.Windows.Forms.MessageBox.Show("terzo");
            this.nome = "Mannaro";
        }
        public Mannaro(string nome): base(nome)
        {
            this.nome = "Mannaro" + nome;
        }
        new public void Rivela()
        {
            string s = nome + (char)(32);
            System.Windows.Forms.MessageBox.Show(s + base.nome);
        }
    }
}
