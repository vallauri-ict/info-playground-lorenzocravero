using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_classi_astratte_01
{
    class Studente
    {
        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public string Nome { get; set; }
        public string Cognome { get; set; }

        private DateTime dataNascita;

        public string nomeCompleto()
        {
            return Nome + " " + Cognome;
        }
    }
}
