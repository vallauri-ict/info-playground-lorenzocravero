namespace Multiform01
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
            this.btnAproF2 = new System.Windows.Forms.Button();
            this.btnApriF2b = new System.Windows.Forms.Button();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassaTxt = new System.Windows.Forms.Button();
            this.btnFormModale = new System.Windows.Forms.Button();
            this.lblNomeFMain = new System.Windows.Forms.Label();
            this.txtNomeFMain = new System.Windows.Forms.TextBox();
            this.lbletaFMain = new System.Windows.Forms.Label();
            this.txtEtaFMain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAproF2
            // 
            this.btnAproF2.Location = new System.Drawing.Point(47, 24);
            this.btnAproF2.Name = "btnAproF2";
            this.btnAproF2.Size = new System.Drawing.Size(75, 23);
            this.btnAproF2.TabIndex = 0;
            this.btnAproF2.Text = "Apri Form 2";
            this.btnAproF2.UseVisualStyleBackColor = true;
            this.btnAproF2.Click += new System.EventHandler(this.btnApriF2_Click);
            // 
            // btnApriF2b
            // 
            this.btnApriF2b.Location = new System.Drawing.Point(166, 24);
            this.btnApriF2b.Name = "btnApriF2b";
            this.btnApriF2b.Size = new System.Drawing.Size(75, 23);
            this.btnApriF2b.TabIndex = 1;
            this.btnApriF2b.Text = "Apri Form 2b";
            this.btnApriF2b.UseVisualStyleBackColor = true;
            this.btnApriF2b.Click += new System.EventHandler(this.btnApriF2b_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(47, 67);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(100, 20);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassaTxt
            // 
            this.btnPassaTxt.Location = new System.Drawing.Point(153, 67);
            this.btnPassaTxt.Name = "btnPassaTxt";
            this.btnPassaTxt.Size = new System.Drawing.Size(121, 23);
            this.btnPassaTxt.TabIndex = 3;
            this.btnPassaTxt.Text = "Passa TXT a F2";
            this.btnPassaTxt.UseVisualStyleBackColor = true;
            this.btnPassaTxt.Click += new System.EventHandler(this.btnPassaTxt_Click);
            // 
            // btnFormModale
            // 
            this.btnFormModale.Location = new System.Drawing.Point(47, 170);
            this.btnFormModale.Name = "btnFormModale";
            this.btnFormModale.Size = new System.Drawing.Size(100, 23);
            this.btnFormModale.TabIndex = 4;
            this.btnFormModale.Text = "Apri Form Modale";
            this.btnFormModale.UseVisualStyleBackColor = true;
            this.btnFormModale.Click += new System.EventHandler(this.btnFormModale_Click);
            // 
            // lblNomeFMain
            // 
            this.lblNomeFMain.AutoSize = true;
            this.lblNomeFMain.Location = new System.Drawing.Point(44, 102);
            this.lblNomeFMain.Name = "lblNomeFMain";
            this.lblNomeFMain.Size = new System.Drawing.Size(35, 13);
            this.lblNomeFMain.TabIndex = 5;
            this.lblNomeFMain.Text = "Nome";
            // 
            // txtNomeFMain
            // 
            this.txtNomeFMain.Location = new System.Drawing.Point(47, 128);
            this.txtNomeFMain.Name = "txtNomeFMain";
            this.txtNomeFMain.ReadOnly = true;
            this.txtNomeFMain.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFMain.TabIndex = 6;
            // 
            // lbletaFMain
            // 
            this.lbletaFMain.AutoSize = true;
            this.lbletaFMain.Location = new System.Drawing.Point(206, 102);
            this.lbletaFMain.Name = "lbletaFMain";
            this.lbletaFMain.Size = new System.Drawing.Size(23, 13);
            this.lbletaFMain.TabIndex = 7;
            this.lbletaFMain.Text = "Eta";
            // 
            // txtEtaFMain
            // 
            this.txtEtaFMain.Location = new System.Drawing.Point(209, 128);
            this.txtEtaFMain.Name = "txtEtaFMain";
            this.txtEtaFMain.ReadOnly = true;
            this.txtEtaFMain.Size = new System.Drawing.Size(100, 20);
            this.txtEtaFMain.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEtaFMain);
            this.Controls.Add(this.lbletaFMain);
            this.Controls.Add(this.txtNomeFMain);
            this.Controls.Add(this.lblNomeFMain);
            this.Controls.Add(this.btnFormModale);
            this.Controls.Add(this.btnPassaTxt);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.btnApriF2b);
            this.Controls.Add(this.btnAproF2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAproF2;
        private System.Windows.Forms.Button btnApriF2b;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.Button btnPassaTxt;
        private System.Windows.Forms.Button btnFormModale;
        private System.Windows.Forms.Label lblNomeFMain;
        private System.Windows.Forms.TextBox txtNomeFMain;
        private System.Windows.Forms.Label lbletaFMain;
        private System.Windows.Forms.TextBox txtEtaFMain;
    }
}

