namespace _23_EreditarietàGiocoTresette
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
            this.btnInserisci = new System.Windows.Forms.Button();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeme = new System.Windows.Forms.TextBox();
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(12, 103);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(115, 35);
            this.btnInserisci.TabIndex = 0;
            this.btnInserisci.Text = "Inserisci Carta";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(100, 24);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(100, 20);
            this.txtValore.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seme:";
            // 
            // txtSeme
            // 
            this.txtSeme.Location = new System.Drawing.Point(100, 58);
            this.txtSeme.Name = "txtSeme";
            this.txtSeme.Size = new System.Drawing.Size(100, 20);
            this.txtSeme.TabIndex = 3;
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(148, 103);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(115, 35);
            this.btnCarta.TabIndex = 5;
            this.btnCarta.Text = "Dammi Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(293, 103);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(115, 35);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Cerca Carta";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 202);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValore);
            this.Controls.Add(this.btnInserisci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.TextBox txtValore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeme;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button btnFind;
    }
}

