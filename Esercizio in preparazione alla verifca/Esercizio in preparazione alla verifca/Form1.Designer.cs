namespace Esercizio_in_preparazione_alla_verifca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeMain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognomeMain = new System.Windows.Forms.TextBox();
            this.txtEtaMain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPassa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModificaMain = new System.Windows.Forms.TextBox();
            this.btnModificaMain = new System.Windows.Forms.Button();
            this.terzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome ";
            // 
            // txtNomeMain
            // 
            this.txtNomeMain.Location = new System.Drawing.Point(32, 51);
            this.txtNomeMain.Name = "txtNomeMain";
            this.txtNomeMain.Size = new System.Drawing.Size(100, 20);
            this.txtNomeMain.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome ";
            // 
            // txtCognomeMain
            // 
            this.txtCognomeMain.Location = new System.Drawing.Point(32, 124);
            this.txtCognomeMain.Name = "txtCognomeMain";
            this.txtCognomeMain.Size = new System.Drawing.Size(100, 20);
            this.txtCognomeMain.TabIndex = 3;
            // 
            // txtEtaMain
            // 
            this.txtEtaMain.Location = new System.Drawing.Point(32, 188);
            this.txtEtaMain.Name = "txtEtaMain";
            this.txtEtaMain.Size = new System.Drawing.Size(100, 20);
            this.txtEtaMain.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Età";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figliaToolStripMenuItem,
            this.secondariaToolStripMenuItem,
            this.terzaToolStripMenuItem});
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
            // txtPassa
            // 
            this.txtPassa.Location = new System.Drawing.Point(212, 51);
            this.txtPassa.Name = "txtPassa";
            this.txtPassa.Size = new System.Drawing.Size(100, 20);
            this.txtPassa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valore da passare";
            // 
            // txtModificaMain
            // 
            this.txtModificaMain.Location = new System.Drawing.Point(201, 146);
            this.txtModificaMain.Name = "txtModificaMain";
            this.txtModificaMain.Size = new System.Drawing.Size(100, 20);
            this.txtModificaMain.TabIndex = 9;
            // 
            // btnModificaMain
            // 
            this.btnModificaMain.Location = new System.Drawing.Point(201, 108);
            this.btnModificaMain.Name = "btnModificaMain";
            this.btnModificaMain.Size = new System.Drawing.Size(75, 23);
            this.btnModificaMain.TabIndex = 10;
            this.btnModificaMain.Text = "Modifica";
            this.btnModificaMain.UseVisualStyleBackColor = true;
            this.btnModificaMain.Click += new System.EventHandler(this.BtnModificaMain_Click);
            // 
            // terzaToolStripMenuItem
            // 
            this.terzaToolStripMenuItem.Name = "terzaToolStripMenuItem";
            this.terzaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.terzaToolStripMenuItem.Text = "Terza";
            this.terzaToolStripMenuItem.Click += new System.EventHandler(this.TerzaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 249);
            this.Controls.Add(this.btnModificaMain);
            this.Controls.Add(this.txtModificaMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEtaMain);
            this.Controls.Add(this.txtCognomeMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeMain);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognomeMain;
        private System.Windows.Forms.TextBox txtEtaMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondariaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPassa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModificaMain;
        private System.Windows.Forms.Button btnModificaMain;
        private System.Windows.Forms.ToolStripMenuItem terzaToolStripMenuItem;
    }
}

