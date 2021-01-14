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
        public struct userName
        {
            public string user;
        }
        public static List<userName> miaLista = new List<userName>();

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
            s = "Codice fiscale: " + txtCod.Text;
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
            userName u = miaLista.Find(x => x.user == utente);
            if(u.user!=null)
            {
                valido = false;
            }
            return valido;
        }

        public static void inserisciUtente(string username)
        {
            //dichiaro un elemento della lista associato alla struttura
            userName utente;
            utente.user = username;

            //aggiungo l'elemento nella lista
            miaLista.Add(utente);
        }
    }
}
