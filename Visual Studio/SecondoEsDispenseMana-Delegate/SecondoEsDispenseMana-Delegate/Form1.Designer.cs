namespace SecondoEsDispenseMana_Delegate
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
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnIcrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(12, 12);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(100, 20);
            this.txtMaxValue.TabIndex = 0;
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(12, 56);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(86, 23);
            this.btnCrea.TabIndex = 1;
            this.btnCrea.Text = "Create";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.BtnCrea_Click);
            // 
            // btnIcrement
            // 
            this.btnIcrement.Location = new System.Drawing.Point(12, 95);
            this.btnIcrement.Name = "btnIcrement";
            this.btnIcrement.Size = new System.Drawing.Size(86, 23);
            this.btnIcrement.TabIndex = 2;
            this.btnIcrement.Text = "Increment";
            this.btnIcrement.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 161);
            this.Controls.Add(this.btnIcrement);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.txtMaxValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnIcrement;
    }
}

