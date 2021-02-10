using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfacce_1
{
    public partial class Form1 : Form
    {
        MyComponent com = new MyComponent();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            com.connetti("Componente 1");
        }

        private void btnDisconnetti_Click(object sender, EventArgs e)
        {
            com.disconnetti("Componente 1");
        }

        private void btnStato_Click(object sender, EventArgs e)
        {
            com.Stato();
        }
    }
}
