using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrazione_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;
            string nomeUtente = "";

            //cognome
            Regex cognome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if(txtCognome.Text=="")
            {
                MessageBox.Show("Cognome non inserito");
                valido = false;
                txtCognome.Focus();
            }
            else
            {
                if(!cognome.IsMatch(txtCognome.Text))
                {
                    valido = false;
                    MessageBox.Show("Cognome non valido");
                    txtCognome.Focus();
                }
            }

            //nome
            Regex nome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome non inserito");
                valido = false;
                txtNome.Focus();
            }
            else
            {
                if (!nome.IsMatch(txtNome.Text))
                {
                    valido = false;
                    MessageBox.Show("Nome non valido");
                    txtNome.Focus();
                }
            }

            //indirizzo
            Regex indirizzo = new Regex(@"^[A-Z]{1}[a-z]{2}\s[A-Z]{1}[a-z]{1,10}\s\d{1}$");
            if (txtIndirizzo.Text == "")
            {
                MessageBox.Show("Indirizzo non inserito");
                valido = false;
                txtIndirizzo.Focus();
            }
            else
            {
                if (!indirizzo.IsMatch(txtIndirizzo.Text))
                {
                    valido = false;
                    MessageBox.Show("Indirizzo non valido");
                    txtIndirizzo.Focus();
                }
            }

            //citta
            Regex citta = new Regex(@"^[A-Z]{1}[a-z]{1,15}$");
            if (txtCitta.Text == "")
            {
                MessageBox.Show("Città non inserita");
                valido = false;
                txtCitta.Focus();
            }
            else
            {
                if (!citta.IsMatch(txtCitta.Text))
                {
                    valido = false;
                    MessageBox.Show("Città non valida");
                    txtCitta.Focus();
                }
            }

            //cap
            Regex cap = new Regex(@"\d{5}");
            if(txtCap.Text=="")
            {
                MessageBox.Show("CAP non inserito");
                valido = false;
                txtCap.Focus();
            }
            else
            {
                if (!cap.IsMatch(txtCap.Text))
                {
                    valido = false;
                    MessageBox.Show("CAP non valido");
                    txtCap.Focus();
                }
            }

            //mail
            Regex mail = new Regex(@"^[A-z0-9\.\+_-]+@[A-z0-9\._-]+\.[A-z]{2,6}$");
            if (txtMail.Text == "")
            {
                MessageBox.Show("Mail non valida");
                valido = false;
                txtMail.Focus();
            }
            else
            {
                if (!mail.IsMatch(txtMail.Text))
                {
                    valido = false;
                    MessageBox.Show("Mail non valida");
                    txtMail.Focus();
                }
            }

            //codice fiscale
            Regex cod = new Regex(@"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$");
            if (txtCod.Text == "")
            {
                MessageBox.Show("Codice fiscale non inserito");
                valido = false;
                txtCod.Focus();
            }
            else
            {
                if (!cod.IsMatch(txtCod.Text))
                {
                    valido = false;
                    MessageBox.Show("Codice fiscale non valido");
                    txtCod.Focus();
                }
            }

            //username
            if(txtUser.Text=="")
            {
                MessageBox.Show("Username mancante");
            }
            else
            {
                valido=Utenti.controllautente(txtUser.Text);
                if(!valido)
                {
                    MessageBox.Show("Nome utente già esistente");
                }
                else
                {
                    nomeUtente = txtUser.Text;
                }
            }
            
            //password
            Regex password = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$");
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password non valida");
                valido = false;
                txtPassword.Focus();
            }
            else
            {
                if (!password.IsMatch(txtPassword.Text))
                {
                    valido = false;
                    MessageBox.Show("Password non valida");
                    txtPassword.Focus();
                }
            }

            //controllo dei campi
            if(valido)
            {
                //vado ad inserire i dati nel file di testo
                Utenti.inserisciDati(txtCognome, txtCap, txtCitta, txtCod, txtIndirizzo, txtMail, txtNome, txtPassword, txtUser);
                Utenti.inserisciUtente(nomeUtente);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCognome.Focus();
        }
    }
}
