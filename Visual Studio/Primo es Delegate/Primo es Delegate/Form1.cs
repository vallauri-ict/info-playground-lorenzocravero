using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo_es_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //dichiarazione del delegate
        public delegate int Operazione(int a, int b);

        //dichiaro le 3 funzioni che utilizzerò con il delegate
        public int Somma(int x,int y)
        {
            return x + y;
        }

        public int Sottrazione(int x, int y)
        {
            return x - y;
        }

        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        public int dif(int a, int b, Operazione op)
        {
            if(a>=b)
            {
                return op(a, b);
            }
            else
            {
                return op(b, a); 
            }
        }

        private void BtnAddizione_Click(object sender, EventArgs e)
        {
            //PRIMO METODO per usare i delegate
            //istanzio il delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma);  //somma è la funzione puntata dal delegate


            //richiamo il delegate che eseguirà la funzione somma
            MessageBox.Show("Somma = "+op(10,15));
        }

        private void BtnMoltiplicazione_Click(object sender, EventArgs e)
        {
            //SECONDO METODO
            Operazione op = Prodotto; //istanziazione più veloce ma è la stessa di prima alla fine
            MessageBox.Show("Prodotto = "+op(10,15));
        }

        private void BtnSottrazione_Click(object sender, EventArgs e)
        {
            //TERZO METODO
            /*Operazione op = Sottrazione;

            MessageBox.Show("Sottrazione = " + op(15, 10));*/

            //istanzio il delegato
            Operazione op = Sottrazione;

            //richiamo dif passandogli come parametro il delegato
            MessageBox.Show("Differenza = " + dif(10, 12, op).ToString());
        }
    }
}
