namespace _22_Scopa
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
            this.btnMazzo = new System.Windows.Forms.Button();
            this.btnPesca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMazzo
            // 
            this.btnMazzo.Location = new System.Drawing.Point(78, 82);
            this.btnMazzo.Name = "btnMazzo";
            this.btnMazzo.Size = new System.Drawing.Size(75, 56);
            this.btnMazzo.TabIndex = 0;
            this.btnMazzo.Text = "MAZZO";
            this.btnMazzo.UseVisualStyleBackColor = true;
            // 
            // btnPesca
            // 
            this.btnPesca.Location = new System.Drawing.Point(216, 82);
            this.btnPesca.Name = "btnPesca";
            this.btnPesca.Size = new System.Drawing.Size(75, 56);
            this.btnPesca.TabIndex = 1;
            this.btnPesca.Text = "PESCA";
            this.btnPesca.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 231);
            this.Controls.Add(this.btnPesca);
            this.Controls.Add(this.btnMazzo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMazzo;
        private System.Windows.Forms.Button btnPesca;
    }
}

