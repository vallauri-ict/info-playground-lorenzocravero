using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_026_Stagisti
{
    class Stagista : Alunno
    {
        #region attributi

        private string azienda;
        private int ore;
        
        #endregion

        public string Azienda 
        { 
            get => azienda; 
            set => azienda = value; 
        }

        public string Ore
        { 
            get
            {
                return ore.ToString();
            }
            set
            {
                if (Convert.ToInt32(value) < 1)
                {
                    throw new Exception("Numero di ore non valido");
                }
                else
                    ore = Convert.ToInt32(value);
            }
        }

        public Stagista(string nome, string cognome, string citta, string classe, string sezione, string specializzazione, string azienda, string ore) : base(nome, cognome,citta,classe,sezione,specializzazione)
        {
            Azienda = azienda;
            Ore = ore;
        }

        public override string visualizza()
        {
            return base.visualizza() + " " + Azienda + " " + Ore;
        }
    }
}
