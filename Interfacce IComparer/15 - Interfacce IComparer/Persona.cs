using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Interfacce_IComparer
{
    class Persona
    {
        private string nome;
        private string cognome;
        private string citta;

        public Persona(string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Citta { get => citta; set => citta = value; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1; //un oggetto null è più piccolo 
            Persona p = obj as Persona;
            return String.Compare(Cognome, p.Cognome, true); //true per il case sensitive
        }

        public override string ToString()
        {
            return Cognome + " " + Nome + " " + Citta;
        }

        public class ConfrontaCognome : IComparer<Object>
        {
            public int Compare(object x, object y)
            {
                if (x == null && y == null) return 0;
                else if (x == null) return 1;
                else if (y == null) return -1;
                else
                {
                    Persona p1 = (Persona)x;
                    Persona p2 = (Persona)y;
                    return String.Compare(p1.Cognome, p2.Cognome, true);
                }
            }
        }

        public class ConfrontaNome : IComparer<Object>
        {
            public int Compare(object x, object y)
            {
                if (x == null && y == null) return 0;
                else if (x == null) return 1;
                else if (y == null) return -1;
                else
                {
                    Persona p1 = (Persona)x;
                    Persona p2 = (Persona)y;
                    return String.Compare(p1.Nome, p2.Nome, true);
                }
            }
        }
    }
}
