using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userl_Control
{
    public partial class UcTextBox : UserControl
    {
        private bool numero = false; // se true la textboxaccetta solo numeri
        private string testo; // testo della textbox
        private int cifreDecimali = 0; //contiene il numero di cifre decimali dopo la virgola

        public UcTextBox()
        {
            InitializeComponent();
        }

        public bool Numero
        {
            get => numero;
            set => numero = value;
        }
        public string Testo
        {
            get => testo = txtTesto.Text;
            set
            {
                testo = value;
                txtTesto.Text = testo;
            }
        }
        public int CifreDecimali
        {
            get => cifreDecimali;
            set
            {
                cifreDecimali = value;
                reimpostaTesto();
            }
        }

        /*private void TxtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(numero)
            {
                if(!(char.IsDigit(e.KeyChar)) || e.KeyChar == ',' || char.IsControl(e.KeyChar))
                {
                    throw new NotImplementedException();
                }
            }
        }*/


        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if(numero)
            {
                if(!(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void reimpostaTesto()
        {
            if (numero && Testo != "")
            {
                try
                {
                    //controllare che non ci siano più di 1 virgola
                    if (ContaVirgola(Testo) > 1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }

                    //controllo dei decimali
                    double numero = Math.Round(Convert.ToDouble(testo));
                    Testo = numero.ToString();


                }
                catch (Exception e)
                {
                    throw new Exception("Valore non valido");
                }
            }
        }

        private int ContaVirgola(string t)
        {
            int cont = 0;

            for (int i = 0; i < t.Length; i++)
            {
                char c = Convert.ToChar(t.Substring(i, 1));
                if (c == ',')
                {
                    cont++;
                }
            }

            return cont;
        }

        private void TxtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (numero)
            {
                if (!(char.IsDigit(e.KeyChar)) || e.KeyChar == ',' || char.IsControl(e.KeyChar))
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}

