using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_4_da_solo
{
    public class Queue
    {
        public static Queue<string> coda = new Queue<string>();

        public static void inserisci(string item)
        {
            coda.Enqueue(item);
            System.Windows.Forms.MessageBox.Show(item+" aggiunto alla coda");
        }

        public static string estrai(string item)
        {
            string s = "Coda vuota,aggiungi un elemento prima di estrarre";
            try
            {
                s = "Estratto: "+coda.Dequeue();
            }
            catch (Exception)
            {
               
            }
            return s;
        }
    }
}
