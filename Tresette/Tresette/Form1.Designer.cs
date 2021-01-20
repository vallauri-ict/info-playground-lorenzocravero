namespace Tresette
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
            this.btnEstraiPrima = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnProponi = new System.Windows.Forms.Button();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeme = new System.Windows.Forms.TextBox();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEstraiPrima
            // 
            this.btnEstraiPrima.Location = new System.Drawing.Point(197, 231);
            this.btnEstraiPrima.Name = "btnEstraiPrima";
            this.btnEstraiPrima.Size = new System.Drawing.Size(75, 23);
            this.btnEstraiPrima.TabIndex = 0;
            this.btnEstraiPrima.Text = "Estrai prima";
            this.btnEstraiPrima.UseVisualStyleBackColor = true;
            this.btnEstraiPrima.Click += new System.EventHandler(this.BtnEstraiPrima_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(51, 231);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 1;
            this.btnInserisci.Text = "Inserisci carta";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.BtnInserisci_Click);
            // 
            // btnProponi
            // 
            this.btnProponi.Location = new System.Drawing.Point(51, 175);
            this.btnProponi.Name = "btnProponi";
            this.btnProponi.Size = new System.Drawing.Size(75, 23);
            this.btnProponi.TabIndex = 2;
            this.btnProponi.Text = "Proponi";
            this.btnProponi.UseVisualStyleBackColor = true;
            this.btnProponi.Click += new System.EventHandler(this.BtnProponi_Click);
            // 
            // btnEstrai
            // 
            this.btnEstrai.Location = new System.Drawing.Point(197, 175);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(75, 23);
            this.btnEstrai.TabIndex = 3;
            this.btnEstrai.Text = "Estrai";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.BtnEstrai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seme";
            // 
            // txtSeme
            // 
            this.txtSeme.Location = new System.Drawing.Point(142, 76);
            this.txtSeme.Name = "txtSeme";
            this.txtSeme.Size = new System.Drawing.Size(100, 20);
            this.txtSeme.TabIndex = 6;
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(142, 114);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(100, 20);
            this.txtValore.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 324);
            this.Controls.Add(this.txtValore);
            this.Controls.Add(this.txtSeme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnProponi);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.btnEstraiPrima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstraiPrima;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnProponi;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeme;
        private System.Windows.Forms.TextBox txtValore;
    }
}

