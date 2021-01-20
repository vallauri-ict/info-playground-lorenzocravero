using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresette
{
    class MazzoCarte
    {
        private int prog;

        public List<Carte> mazzo = new List<Carte>();

        public void inserisciCarta(Carte carta)
        {
            mazzo.Add(carta);
        }

        public Carte dammiCarta()
        {
            return mazzo.First();
        }

        public Carte dammiCarta(string valore, string seme)
        {
            return null;
        }

        public void mescolaCarte()
        {

        }
    }
}
