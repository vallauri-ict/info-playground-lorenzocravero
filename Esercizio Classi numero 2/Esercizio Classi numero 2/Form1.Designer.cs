namespace Esercizio_Classi_numero_2
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
            this.lblQuadrato = new System.Windows.Forms.Label();
            this.txtLatoQuadrato = new System.Windows.Forms.TextBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuadrato
            // 
            this.lblQuadrato.AutoSize = true;
            this.lblQuadrato.Location = new System.Drawing.Point(12, 9);
            this.lblQuadrato.Name = "lblQuadrato";
            this.lblQuadrato.Size = new System.Drawing.Size(134, 13);
            this.lblQuadrato.TabIndex = 0;
            this.lblQuadrato.Text = "Inserisci il lato del quadrato";
            // 
            // txtLatoQuadrato
            // 
            this.txtLatoQuadrato.Location = new System.Drawing.Point(152, 6);
            this.txtLatoQuadrato.Name = "txtLatoQuadrato";
            this.txtLatoQuadrato.Size = new System.Drawing.Size(100, 20);
            this.txtLatoQuadrato.TabIndex = 1;
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(107, 48);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(93, 23);
            this.btnCrea.TabIndex = 2;
            this.btnCrea.Text = "Crea Quadrato";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.BtnCrea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 205);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.txtLatoQuadrato);
            this.Controls.Add(this.lblQuadrato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuadrato;
        private System.Windows.Forms.TextBox txtLatoQuadrato;
        private System.Windows.Forms.Button btnCrea;
    }
}

