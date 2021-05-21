﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Form_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF1_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.Text = "Figlia 1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 20);
            f.Show();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Figlia2 f = new Figlia2();
            f.Text = "Figlia 2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(215, 20);
            f.Show();
        }

        private void btnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte "+this.MdiChildren.Length+" finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra "+f.Text+" aperta");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire";
            if(f.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.Text = "Figlia 1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 20);
            f.Show();
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figlia2 f = new Figlia2();
            f.Text = "Figlia 2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(215, 20);
            f.Show();
        }
    }
}
