using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrazione_form
{
    class Utenti
    {
        //public static string[] utenti = {"default","default", "default", "default", "default", "default", "default", "default", "default", "default" };
        public static string[] utenti = new string[10];

        public static void inserisciDati(TextBox txtCognome, TextBox txtCap, TextBox txtCitta, TextBox txtCod, TextBox txtIndirizzo, TextBox txtMail, TextBox txtNome, TextBox txtPassword, TextBox txtUser)
        {
            StreamWriter sw = new StreamWriter("dati.txt", false);
            string s = "";
            s = "Cognome: " + txtCognome.Text;
            sw.WriteLine(s);
            s = "Nome: " + txtNome.Text;
            sw.WriteLine(s);
            s = "Indirizzo: " + txtIndirizzo.Text;
            sw.WriteLine(s);
            s = "Città: " + txtCitta.Text;
            sw.WriteLine(s);
            s = "CAP: " + txtCap.Text;
            sw.WriteLine(s);
            s = "Mail: " + txtMail.Text;
            sw.WriteLine(s);
            s = "Codice fisacle: " + txtCod.Text;
            sw.WriteLine(s);
            s = "Username: " + txtUser.Text;
            sw.WriteLine(s);
            s = "Password: " + txtPassword.Text;
            sw.WriteLine(s);

            sw.Close();
        }

        public static bool controllautente(string utente)
        {
            bool valido = true;
            int i = 0;
            while ((utenti[i]!=utente)&&(i!=utenti.Length-1))
            {
                i++;
            }
            if(utenti[i]==utente)
            {
                valido = false;
            }
            return valido;
        }

        public static void inserisciUtente(string username)
        {
            bool inserito = false;
            int i = 0;
            while (!inserito)
            {
                if(utenti[i]=="default")
                {
                    utenti[i] = username;
                    inserito = true;
                }
            }
        }
    }
}
