using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_liste
{
    public class book
    {
        public string titolo;
        public string autore;
        public int id;

        public book(string a, string b, int c)
        {
            this.titolo = a;
            this.autore = b;
            this.id = c;
        }
    }
}
