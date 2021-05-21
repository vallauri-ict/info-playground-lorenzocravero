namespace Quaternioni
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImmaginarioD = new System.Windows.Forms.TextBox();
            this.txtImmaginarioC = new System.Windows.Forms.TextBox();
            this.txtImmaginario = new System.Windows.Forms.TextBox();
            this.txtReale = new System.Windows.Forms.TextBox();
            this.btnComplesso = new System.Windows.Forms.Button();
            this.btnQuaternione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Immaginario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ImmaginarioC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ImmaginarioD";
            // 
            // txtImmaginarioD
            // 
            this.txtImmaginarioD.Location = new System.Drawing.Point(197, 128);
            this.txtImmaginarioD.Name = "txtImmaginarioD";
            this.txtImmaginarioD.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginarioD.TabIndex = 5;
            // 
            // txtImmaginarioC
            // 
            this.txtImmaginarioC.Location = new System.Drawing.Point(197, 88);
            this.txtImmaginarioC.Name = "txtImmaginarioC";
            this.txtImmaginarioC.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginarioC.TabIndex = 6;
            // 
            // txtImmaginario
            // 
            this.txtImmaginario.Location = new System.Drawing.Point(197, 54);
            this.txtImmaginario.Name = "txtImmaginario";
            this.txtImmaginario.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginario.TabIndex = 7;
            // 
            // txtReale
            // 
            this.txtReale.Location = new System.Drawing.Point(197, 23);
            this.txtReale.Name = "txtReale";
            this.txtReale.Size = new System.Drawing.Size(100, 20);
            this.txtReale.TabIndex = 8;
            // 
            // btnComplesso
            // 
            this.btnComplesso.Location = new System.Drawing.Point(44, 192);
            this.btnComplesso.Name = "btnComplesso";
            this.btnComplesso.Size = new System.Drawing.Size(107, 23);
            this.btnComplesso.TabIndex = 9;
            this.btnComplesso.Text = "Modulo complesso";
            this.btnComplesso.UseVisualStyleBackColor = true;
            this.btnComplesso.Click += new System.EventHandler(this.BtnComplesso_Click);
            // 
            // btnQuaternione
            // 
            this.btnQuaternione.Location = new System.Drawing.Point(177, 192);
            this.btnQuaternione.Name = "btnQuaternione";
            this.btnQuaternione.Size = new System.Drawing.Size(120, 23);
            this.btnQuaternione.TabIndex = 10;
            this.btnQuaternione.Text = "Modulo quaternione";
            this.btnQuaternione.UseVisualStyleBackColor = true;
            this.btnQuaternione.Click += new System.EventHandler(this.BtnQuaternione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 344);
            this.Controls.Add(this.btnQuaternione);
            this.Controls.Add(this.btnComplesso);
            this.Controls.Add(this.txtReale);
            this.Controls.Add(this.txtImmaginario);
            this.Controls.Add(this.txtImmaginarioC);
            this.Controls.Add(this.txtImmaginarioD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImmaginarioD;
        private System.Windows.Forms.TextBox txtImmaginarioC;
        private System.Windows.Forms.TextBox txtImmaginario;
        private System.Windows.Forms.TextBox txtReale;
        private System.Windows.Forms.Button btnComplesso;
        private System.Windows.Forms.Button btnQuaternione;
    }
}

