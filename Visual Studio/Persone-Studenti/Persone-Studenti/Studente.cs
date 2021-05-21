using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone_Studenti
{
    class Studente : Persona
    {
        public List<int> voti = new List<int>();

        public Studente()
        {

        }

        public double media()
        {
            int sommaVoti = 0;
            foreach (var voto in voti)
            {
                sommaVoti += voto;
            }
            return (double)sommaVoti / voti.Count();
        }
    }
}
