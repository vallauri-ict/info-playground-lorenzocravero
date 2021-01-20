using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresette
{
    class Carte
    {
        private string valore;
        private string seme;

        private string[] valori = { "Asso", "2", "3", "4", "5", "6", "7", "Fante", "Regina", "Re" };
        private string[] semi = { "Cuori", "Picche", "Quadri", "Fiori" };

        public string VALORE
        {
            get => valore;
            set => valore = value;
        }

        public string SEME
        {
            get => seme;
            set => seme = value;
        }

        public string proponi()
        {
            Random rnd = new Random();

            VALORE = valori[rnd.Next(0, valori.Length)];
            SEME = semi[rnd.Next(0, semi.Length)];

            return VALORE + " di " + SEME;
        }
    }
}
