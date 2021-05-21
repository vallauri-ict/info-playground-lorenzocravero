using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_guidato_ereditarietà
{
    public partial class Form1 : Form //se non ci fosse : Form è implicito che la classe creata deriva da object
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
                (sender as Button).Text = "hello";
            if (sender is Label)
                (sender as Label).BackColor = Color.Red;
        }
    }
}
