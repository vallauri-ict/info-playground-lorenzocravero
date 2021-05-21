namespace Stagisti
{
    abstract class clsPersona
    {
        #region attributi

        private string nome;
        private string cognome;
        private string citta;

        public string Citta
        {
            get => citta;
            set
            {
                if (value.Trim().Length >= 2) //trim toglie gli spazi prima e dopo
                {
                    citta = value;
                }
                else
                {
                    throw new System.Exception("Città non valida");
                }
            }
        }

        public string Cognome
        {
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    cognome = value;
                }
                else
                {
                    throw new System.Exception("Cognome non valido");
                }
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    nome = value;
                }
                else
                {
                    throw new System.Exception("Nome non valido");
                }
            }
        }

        protected clsPersona(string nome, string cognome, string città)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = città;

        }

        public abstract string visualizza();


        #endregion
    }
}
