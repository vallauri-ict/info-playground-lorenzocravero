namespace Primo_es_Delegate
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
            this.btnAddizione = new System.Windows.Forms.Button();
            this.btnMoltiplicazione = new System.Windows.Forms.Button();
            this.btnSottrazione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddizione
            // 
            this.btnAddizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddizione.Location = new System.Drawing.Point(47, 30);
            this.btnAddizione.Name = "btnAddizione";
            this.btnAddizione.Size = new System.Drawing.Size(94, 44);
            this.btnAddizione.TabIndex = 0;
            this.btnAddizione.Text = "+";
            this.btnAddizione.UseVisualStyleBackColor = true;
            this.btnAddizione.Click += new System.EventHandler(this.BtnAddizione_Click);
            // 
            // btnMoltiplicazione
            // 
            this.btnMoltiplicazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoltiplicazione.Location = new System.Drawing.Point(164, 30);
            this.btnMoltiplicazione.Name = "btnMoltiplicazione";
            this.btnMoltiplicazione.Size = new System.Drawing.Size(94, 44);
            this.btnMoltiplicazione.TabIndex = 1;
            this.btnMoltiplicazione.Text = "x";
            this.btnMoltiplicazione.UseVisualStyleBackColor = true;
            this.btnMoltiplicazione.Click += new System.EventHandler(this.BtnMoltiplicazione_Click);
            // 
            // btnSottrazione
            // 
            this.btnSottrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSottrazione.Location = new System.Drawing.Point(275, 30);
            this.btnSottrazione.Name = "btnSottrazione";
            this.btnSottrazione.Size = new System.Drawing.Size(94, 44);
            this.btnSottrazione.TabIndex = 2;
            this.btnSottrazione.Text = "-";
            this.btnSottrazione.UseVisualStyleBackColor = true;
            this.btnSottrazione.Click += new System.EventHandler(this.BtnSottrazione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 105);
            this.Controls.Add(this.btnSottrazione);
            this.Controls.Add(this.btnMoltiplicazione);
            this.Controls.Add(this.btnAddizione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddizione;
        private System.Windows.Forms.Button btnMoltiplicazione;
        private System.Windows.Forms.Button btnSottrazione;
    }
}

