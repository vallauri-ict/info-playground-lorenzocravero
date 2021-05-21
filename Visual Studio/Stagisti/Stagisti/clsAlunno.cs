using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stagisti
{
    class clsAlunno : clsPersona
    {
        #region attributi

        protected static int progressivo = 0;
        protected readonly string matricola;
        private char classe;
        private char sezione;
        private string specialiizazione;

        public string Matricola => matricola;
        public char Classe { get => classe; set => classe = Convert.ToChar(value); }
        public char Sezione { get => sezione; set => sezione = Convert.ToChar(value); }
        public string Specialiizazione { get => specialiizazione; set => specialiizazione = value; }

        #endregion



        public clsAlunno(string nome, string cognome, string città) : base(nome, cognome, città)
        {

        }

        public override string visualizza()
        {
            throw new NotImplementedException();
        }
    }
}
