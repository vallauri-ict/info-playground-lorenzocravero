using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_ereditarietà_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Mostro Clona_V(Mostro p)
        {
            //essendo un passaggio per valore il parametro passato NON cambia ma verrà restituito un nuovo mostro
            //con le modifiche effettuate
            p = new Mostro();
            p.nome = "Cambia solo il secondo";
            return p;
        }

        public Mostro Clona_R(ref Mostro p)
        {
            //essendo un passaggio per referenza ANCHE l'oggetto passato cambierà il suo nome
            p = new Mostro("Referx");
            p.nome = "Cambiano entrambi i nomi";
            return p;
        }

        public Mostro Clona_O(out Mostro p)
        {
            p = new Mostro("Resulx");
            p.nome = "Cambia";
            return p;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mannaro x = new Mannaro();
            Mostro y;
            y = Clona_V(x);
            x.Rivela();
            y.Rivela();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = Clona_R(ref x);
            x.Rivela();
            y.Rivela();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = Clona_O(out x);
            x.Rivela();
            y.Rivela();
        }
    }
}
