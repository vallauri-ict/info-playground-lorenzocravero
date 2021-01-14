namespace Negozio
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtCarica = new System.Windows.Forms.Button();
            this.btnVisual = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElementi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRicerca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(82, 31);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(82, 78);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 3;
            // 
            // txtCarica
            // 
            this.txtCarica.Location = new System.Drawing.Point(28, 132);
            this.txtCarica.Name = "txtCarica";
            this.txtCarica.Size = new System.Drawing.Size(75, 23);
            this.txtCarica.TabIndex = 4;
            this.txtCarica.Text = "Carica";
            this.txtCarica.UseVisualStyleBackColor = true;
            this.txtCarica.Click += new System.EventHandler(this.TxtCarica_Click);
            // 
            // btnVisual
            // 
            this.btnVisual.Location = new System.Drawing.Point(130, 132);
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Size = new System.Drawing.Size(75, 23);
            this.btnVisual.TabIndex = 5;
            this.btnVisual.Text = "Visualizza";
            this.btnVisual.UseVisualStyleBackColor = true;
            this.btnVisual.Click += new System.EventHandler(this.BtnVisual_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero elementi";
            // 
            // lblElementi
            // 
            this.lblElementi.AutoSize = true;
            this.lblElementi.Location = new System.Drawing.Point(127, 177);
            this.lblElementi.Name = "lblElementi";
            this.lblElementi.Size = new System.Drawing.Size(13, 13);
            this.lblElementi.TabIndex = 7;
            this.lblElementi.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ricerca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtRicerca
            // 
            this.txtRicerca.Location = new System.Drawing.Point(130, 217);
            this.txtRicerca.Name = "txtRicerca";
            this.txtRicerca.Size = new System.Drawing.Size(100, 20);
            this.txtRicerca.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 283);
            this.Controls.Add(this.txtRicerca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblElementi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVisual);
            this.Controls.Add(this.txtCarica);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button txtCarica;
        private System.Windows.Forms.Button btnVisual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblElementi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRicerca;
    }
}

