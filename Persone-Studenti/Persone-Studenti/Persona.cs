using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone_Studenti
{
    class Persona
    {
        protected string nome;
        protected string cognome;
        protected string sesso;
        protected int eta;

        public void setAttributes(string nome, string cognome, string sesso, int eta)
        {
            /*if(true)
            {

            }*/

            this.nome = nome;
            this.cognome = cognome;
            this.sesso = sesso;
            this.eta = eta;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCognome()
        {
            return this.cognome;
        }

        public string getSesso()
        {
            return this.sesso;
        }

        public int getEta()
        {
            return this.eta;
        }
    }
}
