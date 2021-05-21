using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_026_Stagisti
{
    sealed class Elenco
    {
        List<Alunno> elenco;

        public Elenco()
        {
            elenco = new List<Alunno>();
        }

        public void inserisci(Alunno a)
        {
            elenco.Add(a);
        }

        public void visualizzaDGV(DataGridView dgv)
        {
            dgv.DataSource = typeof(List<>);
            dgv.DataSource = elenco;
        }

        public int OreAzienda(string nomeA)
        {
            int oreTotAzienda = 0;

            foreach (Alunno a in elenco)
            {
                if (a is Stagista)
                {
                    Stagista s = a as Stagista; //Stagista s = (Stagista)a; --> sono la stessa cosa
                    if(s.Azienda == nomeA)
                    {
                        oreTotAzienda += Convert.ToInt32(s.Ore);
                    }
                }
            }

            return oreTotAzienda;
        }

        public void cancella()
        {
            if(elenco.Count == 0)
            {
                throw new Exception("Cancellazione negata, lista vuota");
            }
            else
            {
                elenco.RemoveAt(elenco.Count - 1);
            }
        }

        public void cancellaAPos(int posizione)
        {
            posizione--;
            if (elenco.Count == 0)
            {
                throw new Exception("Cancellazione negata, lista vuota");
            }
            else
            {
                if (posizione < 0 || posizione > elenco.Count - 1)
                {
                    throw new Exception("Cancellazione negata, posizione non valida");
                }
                else
                    elenco.RemoveAt(posizione);
            }
        }
    }
}
