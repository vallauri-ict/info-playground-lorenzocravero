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
        private static int nFattura=0;
        public int x=0;

        public Fatture()
        {
            cntFatture++;
            nFattura = cntFatture;
            x = nFattura;
        }

        public static void visualizza()
        {
            System.Windows.Forms.MessageBox.Show("Numero di fatture create: "+cntFatture);
        }
    }
}
