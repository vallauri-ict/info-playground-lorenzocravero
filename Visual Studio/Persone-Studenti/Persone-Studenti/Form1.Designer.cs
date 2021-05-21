namespace Persone_Studenti
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.Eta = new System.Windows.Forms.Label();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.listStudenti = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnVisualUnoStud = new System.Windows.Forms.Button();
            this.btnAggiungiVoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(85, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(85, 32);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // Eta
            // 
            this.Eta.AutoSize = true;
            this.Eta.Location = new System.Drawing.Point(12, 65);
            this.Eta.Name = "Eta";
            this.Eta.Size = new System.Drawing.Size(23, 13);
            this.Eta.TabIndex = 4;
            this.Eta.Text = "Eta";
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(85, 62);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sesso";
            // 
            // txtSesso
            // 
            this.txtSesso.Location = new System.Drawing.Point(85, 88);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(100, 20);
            this.txtSesso.TabIndex = 7;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(15, 128);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(170, 23);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // listStudenti
            // 
            this.listStudenti.HideSelection = false;
            this.listStudenti.Location = new System.Drawing.Point(244, 12);
            this.listStudenti.Name = "listStudenti";
            this.listStudenti.Size = new System.Drawing.Size(224, 319);
            this.listStudenti.TabIndex = 9;
            this.listStudenti.UseCompatibleStateImageBehavior = false;
            this.listStudenti.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Voto";
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(82, 271);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(100, 20);
            this.txtVoto.TabIndex = 12;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(15, 308);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(170, 23);
            this.btnMedia.TabIndex = 13;
            this.btnMedia.Text = "Visualizza media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.BtnMedia_Click);
            // 
            // btnVisualUnoStud
            // 
            this.btnVisualUnoStud.Location = new System.Drawing.Point(15, 157);
            this.btnVisualUnoStud.Name = "btnVisualUnoStud";
            this.btnVisualUnoStud.Size = new System.Drawing.Size(170, 23);
            this.btnVisualUnoStud.TabIndex = 14;
            this.btnVisualUnoStud.Text = "Voti 1 Studente";
            this.btnVisualUnoStud.UseVisualStyleBackColor = true;
            this.btnVisualUnoStud.Click += new System.EventHandler(this.BtnVisualUnoStud_Click);
            // 
            // btnAggiungiVoto
            // 
            this.btnAggiungiVoto.Location = new System.Drawing.Point(15, 337);
            this.btnAggiungiVoto.Name = "btnAggiungiVoto";
            this.btnAggiungiVoto.Size = new System.Drawing.Size(170, 23);
            this.btnAggiungiVoto.TabIndex = 15;
            this.btnAggiungiVoto.Text = "Aggiungi";
            this.btnAggiungiVoto.UseVisualStyleBackColor = true;
            this.btnAggiungiVoto.Click += new System.EventHandler(this.BtnAggiungiVoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 373);
            this.Controls.Add(this.btnAggiungiVoto);
            this.Controls.Add(this.btnVisualUnoStud);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listStudenti);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.Eta);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label Eta;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ListView listStudenti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnVisualUnoStud;
        private System.Windows.Forms.Button btnAggiungiVoto;
    }
}

