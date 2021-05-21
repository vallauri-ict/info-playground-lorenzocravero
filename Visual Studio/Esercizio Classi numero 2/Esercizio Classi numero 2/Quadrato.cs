using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Classi_numero_2
{
    class Quadrato
    {
        private int lato=0;

        public Quadrato(int lato)
        {
            this.lato = lato;
        }

        public static Quadrato creaQuadrato(int lato)
        {
            if(lato<=0)
            {
                throw new Exception("Il lato del quadrato deve essere maggiore di zero");
            }
            else
            {
                return new Quadrato(lato);
            }
        }
    }
}
