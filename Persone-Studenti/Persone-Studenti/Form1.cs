using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persone_Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Studente> lstStud = new List<Studente>();

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            try
            {
                s.setAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Compila i campi correttamente");
            }
            
            lstStud.Add(s);

            //aggiungiamo a list view

            listStudenti.Items.Add(s.getCognome());
        }

        private void BtnVisualUnoStud_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstStud.Find(stud => stud.getCognome() == listStudenti.SelectedItems[0].Text);
            MessageBox.Show("I voti di "+s.getCognome()+" sono: ");
            foreach (var voto in s.voti)
            {
                MessageBox.Show(voto.ToString());
            }
        }

        private void BtnMedia_Click(object sender, EventArgs e)
        {
            double media = 0;
            string studenteSelezionato = listStudenti.SelectedItems[0].Text;
            foreach (var st in lstStud)
            {
                if(studenteSelezionato == st.getCognome())
                {
                    media = st.media();
                }
            }
            MessageBox.Show("La media di "+ listStudenti.SelectedItems[0].Text+" è "+media.ToString("0.00"));
        }

        private void BtnAggiungiVoto_Click(object sender, EventArgs e)
        {
            int voto = Convert.ToInt32(txtVoto.Text);
            string cognome = listStudenti.SelectedItems[0].Text;
            foreach (var st in lstStud)
            {
                if (cognome == st.getCognome())
                {
                    st.voti.Add(voto);
                }
            }
        }
    }
}
