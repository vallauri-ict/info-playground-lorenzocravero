﻿namespace Esercizio_5_classe_indexata
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
            this.btnCrea = new System.Windows.Forms.Button();
            this.txtElementi = new System.Windows.Forms.TextBox();
            this.btnVisual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(12, 38);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(75, 23);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea classe";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.BtnCrea_Click);
            // 
            // txtElementi
            // 
            this.txtElementi.Location = new System.Drawing.Point(12, 12);
            this.txtElementi.Name = "txtElementi";
            this.txtElementi.Size = new System.Drawing.Size(134, 20);
            this.txtElementi.TabIndex = 1;
            // 
            // btnVisual
            // 
            this.btnVisual.Location = new System.Drawing.Point(12, 67);
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Size = new System.Drawing.Size(75, 23);
            this.btnVisual.TabIndex = 2;
            this.btnVisual.Text = "Visualizza";
            this.btnVisual.UseVisualStyleBackColor = true;
            this.btnVisual.Click += new System.EventHandler(this.BtnVisual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 201);
            this.Controls.Add(this.btnVisual);
            this.Controls.Add(this.txtElementi);
            this.Controls.Add(this.btnCrea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.TextBox txtElementi;
        private System.Windows.Forms.Button btnVisual;
    }
}

