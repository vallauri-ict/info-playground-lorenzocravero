using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1_classi
{
    class Fatture
    {
        private static int cntFatture = 0;
        public readonly int nFattura;

        public Fatture()
        {
            cntFatture++;
            this.nFattura = cntFatture;
        }

        public static void visualizza()
        {
            System.Windows.Forms.MessageBox.Show("Numero di fatture create: "+cntFatture);
            //System.Windows.Forms.MessageBox.Show("Numero di fattura corrente: "+nFattura);
        }
    }
}
