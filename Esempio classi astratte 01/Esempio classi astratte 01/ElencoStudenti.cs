using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempio_classi_astratte_01
{
    class ElencoStudenti : Report
    {
        private List<Studente> lstStudenti = new List<Studente>();
        public string stampa="";
        protected override void printBody()
        {
            string body = "";
            foreach (var stud in lstStudenti)
            {
                body += stud.nomeCompleto() + "\n";
            }
        }

        protected override void printFooter()
        {
            stampa += "FOOTER STAMPA STUDENTI";
        }

        protected override void printHeader()
        {
            stampa += "INTESTAZIONE STAMPA STUDENTI";
        }

        public ElencoStudenti()
        {
            lstStudenti.Add(new Studente("Andrea", "Giaccardi"));
            lstStudenti.Add(new Studente("Ezio", "Tomatis"));
        }

    }
}
