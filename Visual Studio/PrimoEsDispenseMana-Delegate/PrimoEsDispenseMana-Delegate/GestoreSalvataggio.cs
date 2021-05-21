using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimoEsDispenseMana_Delegate
{
    //Dichiarazione del delegato
    public delegate void SalvataggioEseguitoEventHandler(int id);

    class GestoreSalvataggio
    {
        //dichiaro l'evento
        public event SalvataggioEseguitoEventHandler salvataggioEseguito;

        public void SalvaSuFile(int id)
        {
            MessageBox.Show("Sto eseguendo il salvataggio");

            salvataggioEseguito(id);
        }
    }
}
