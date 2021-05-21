namespace Esercizio_di_prova_sulle_classi
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(12, 24);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 0;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(12, 87);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 20);
            this.txtAltezza.TabIndex = 1;
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(147, 24);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(98, 23);
            this.btnCrea.TabIndex = 2;
            this.btnCrea.Text = "Crea Rettangolo";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.BtnCrea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altezza";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(147, 61);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(98, 23);
            this.btnArea.TabIndex = 5;
            this.btnArea.Text = "Calcola Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(147, 100);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(98, 23);
            this.btnPerimetro.TabIndex = 6;
            this.btnPerimetro.Text = "Calcola Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.BtnPerimetro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 163);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.txtBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPerimetro;
    }
}

