namespace _03_MultiformConMenu
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2DinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFormModaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNome = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriForm2ToolStripMenuItem,
            this.apriForm2DinamicaToolStripMenuItem,
            this.apriFormModaleToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // apriForm2ToolStripMenuItem
            // 
            this.apriForm2ToolStripMenuItem.Name = "apriForm2ToolStripMenuItem";
            this.apriForm2ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.apriForm2ToolStripMenuItem.Text = "Apri Form2";
            this.apriForm2ToolStripMenuItem.Click += new System.EventHandler(this.ApriForm2ToolStripMenuItem_Click);
            // 
            // apriForm2DinamicaToolStripMenuItem
            // 
            this.apriForm2DinamicaToolStripMenuItem.Name = "apriForm2DinamicaToolStripMenuItem";
            this.apriForm2DinamicaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.apriForm2DinamicaToolStripMenuItem.Text = "Apri Form2 Dinamica";
            this.apriForm2DinamicaToolStripMenuItem.Click += new System.EventHandler(this.ApriForm2DinamicaToolStripMenuItem_Click);
            // 
            // apriFormModaleToolStripMenuItem
            // 
            this.apriFormModaleToolStripMenuItem.Name = "apriFormModaleToolStripMenuItem";
            this.apriFormModaleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.apriFormModaleToolStripMenuItem.Text = "Apri Form Modale";
            this.apriFormModaleToolStripMenuItem.Click += new System.EventHandler(this.apriFormModaleToolStripMenuItem_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(40, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(43, 93);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 3;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(40, 145);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(23, 13);
            this.lblEta.TabIndex = 4;
            this.lblEta.Text = "Età";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(43, 184);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 388);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriForm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriForm2DinamicaToolStripMenuItem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ToolStripMenuItem apriFormModaleToolStripMenuItem;
    }
}

