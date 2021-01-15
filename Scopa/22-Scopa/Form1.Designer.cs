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
            this.btnMostra = new System.Windows.Forms.Button();
            this.btnEstrai = new System.Windows.Forms.Button();
            this.btnMescola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMazzo
            // 
            this.btnMazzo.Location = new System.Drawing.Point(29, 66);
            this.btnMazzo.Name = "btnMazzo";
            this.btnMazzo.Size = new System.Drawing.Size(93, 56);
            this.btnMazzo.TabIndex = 0;
            this.btnMazzo.Text = "MAZZO";
            this.btnMazzo.UseVisualStyleBackColor = true;
            this.btnMazzo.Click += new System.EventHandler(this.BtnMazzo_Click);
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(272, 66);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(93, 56);
            this.btnMostra.TabIndex = 2;
            this.btnMostra.Text = "MOSTRA MAZZO";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.BtnMostra_Click);
            // 
            // btnEstrai
            // 
            this.btnEstrai.Location = new System.Drawing.Point(154, 12);
            this.btnEstrai.Name = "btnEstrai";
            this.btnEstrai.Size = new System.Drawing.Size(93, 56);
            this.btnEstrai.TabIndex = 3;
            this.btnEstrai.Text = "ESTRAI";
            this.btnEstrai.UseVisualStyleBackColor = true;
            this.btnEstrai.Click += new System.EventHandler(this.BtnEstrai_Click);
            // 
            // btnMescola
            // 
            this.btnMescola.Location = new System.Drawing.Point(154, 128);
            this.btnMescola.Name = "btnMescola";
            this.btnMescola.Size = new System.Drawing.Size(93, 56);
            this.btnMescola.TabIndex = 4;
            this.btnMescola.Text = "MESCOLA MAZZO";
            this.btnMescola.UseVisualStyleBackColor = true;
            this.btnMescola.Click += new System.EventHandler(this.BtnMescola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 231);
            this.Controls.Add(this.btnMescola);
            this.Controls.Add(this.btnEstrai);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.btnMazzo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMazzo;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.Button btnEstrai;
        private System.Windows.Forms.Button btnMescola;
    }
}

