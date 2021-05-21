namespace Esercizio_di_prova_random
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtMainNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lbleta = new System.Windows.Forms.Label();
            this.txtMainEta = new System.Windows.Forms.TextBox();
            this.txtMainCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figliaToolStripMenuItem,
            this.secondariaToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // figliaToolStripMenuItem
            // 
            this.figliaToolStripMenuItem.Name = "figliaToolStripMenuItem";
            this.figliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.figliaToolStripMenuItem.Text = "Figlia";
            this.figliaToolStripMenuItem.Click += new System.EventHandler(this.FigliaToolStripMenuItem_Click);
            // 
            // secondariaToolStripMenuItem
            // 
            this.secondariaToolStripMenuItem.Name = "secondariaToolStripMenuItem";
            this.secondariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.secondariaToolStripMenuItem.Text = "Secondaria";
            this.secondariaToolStripMenuItem.Click += new System.EventHandler(this.SecondariaToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(48, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtMainNome
            // 
            this.txtMainNome.Location = new System.Drawing.Point(51, 63);
            this.txtMainNome.Name = "txtMainNome";
            this.txtMainNome.ReadOnly = true;
            this.txtMainNome.Size = new System.Drawing.Size(100, 20);
            this.txtMainNome.TabIndex = 2;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(48, 118);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 3;
            this.lblCognome.Text = "Cognome";
            // 
            // lbleta
            // 
            this.lbleta.AutoSize = true;
            this.lbleta.Location = new System.Drawing.Point(48, 187);
            this.lbleta.Name = "lbleta";
            this.lbleta.Size = new System.Drawing.Size(23, 13);
            this.lbleta.TabIndex = 4;
            this.lbleta.Text = "Età";
            // 
            // txtMainEta
            // 
            this.txtMainEta.Location = new System.Drawing.Point(51, 203);
            this.txtMainEta.Name = "txtMainEta";
            this.txtMainEta.ReadOnly = true;
            this.txtMainEta.Size = new System.Drawing.Size(100, 20);
            this.txtMainEta.TabIndex = 5;
            // 
            // txtMainCognome
            // 
            this.txtMainCognome.Location = new System.Drawing.Point(51, 134);
            this.txtMainCognome.Name = "txtMainCognome";
            this.txtMainCognome.ReadOnly = true;
            this.txtMainCognome.Size = new System.Drawing.Size(100, 20);
            this.txtMainCognome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valore da passare";
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(223, 134);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(100, 20);
            this.txtValore.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 249);
            this.Controls.Add(this.txtValore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMainCognome);
            this.Controls.Add(this.txtMainEta);
            this.Controls.Add(this.lbleta);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtMainNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtMainNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lbleta;
        private System.Windows.Forms.TextBox txtMainEta;
        private System.Windows.Forms.TextBox txtMainCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValore;
    }
}

