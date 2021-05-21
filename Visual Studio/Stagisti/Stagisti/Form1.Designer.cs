namespace Stagisti
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.Classe = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbAzienda = new System.Windows.Forms.ComboBox();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.cmbSezione = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOre = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnElemento = new System.Windows.Forms.Button();
            this.lblpos = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Città";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(105, 95);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(100, 20);
            this.txtCitta.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(105, 55);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 5;
            // 
            // Classe
            // 
            this.Classe.AutoSize = true;
            this.Classe.Location = new System.Drawing.Point(23, 142);
            this.Classe.Name = "Classe";
            this.Classe.Size = new System.Drawing.Size(38, 13);
            this.Classe.TabIndex = 7;
            this.Classe.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbClasse.Location = new System.Drawing.Point(105, 134);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(100, 21);
            this.cmbClasse.TabIndex = 8;
            // 
            // cmbAzienda
            // 
            this.cmbAzienda.FormattingEnabled = true;
            this.cmbAzienda.Items.AddRange(new object[] {
            "Azienda1",
            "Azienda2",
            "Azienda3"});
            this.cmbAzienda.Location = new System.Drawing.Point(318, 90);
            this.cmbAzienda.Name = "cmbAzienda";
            this.cmbAzienda.Size = new System.Drawing.Size(100, 21);
            this.cmbAzienda.TabIndex = 9;
            // 
            // cmbSpec
            // 
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Items.AddRange(new object[] {
            "INF",
            "ELT",
            "MEC"});
            this.cmbSpec.Location = new System.Drawing.Point(318, 50);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(100, 21);
            this.cmbSpec.TabIndex = 10;
            // 
            // cmbSezione
            // 
            this.cmbSezione.FormattingEnabled = true;
            this.cmbSezione.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSezione.Location = new System.Drawing.Point(318, 15);
            this.cmbSezione.Name = "cmbSezione";
            this.cmbSezione.Size = new System.Drawing.Size(100, 21);
            this.cmbSezione.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Spec.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sezione";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Azienda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Azienda";
            // 
            // txtOre
            // 
            this.txtOre.Location = new System.Drawing.Point(318, 139);
            this.txtOre.Name = "txtOre";
            this.txtOre.Size = new System.Drawing.Size(100, 20);
            this.txtOre.TabIndex = 16;
            this.txtOre.TabStop = false;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(26, 184);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(179, 23);
            this.btnInserisci.TabIndex = 17;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(253, 184);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(165, 23);
            this.btnRicerca.TabIndex = 18;
            this.btnRicerca.Text = "Ricerca Azienda";
            this.btnRicerca.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnElemento
            // 
            this.btnElemento.Location = new System.Drawing.Point(26, 407);
            this.btnElemento.Name = "btnElemento";
            this.btnElemento.Size = new System.Drawing.Size(179, 23);
            this.btnElemento.TabIndex = 20;
            this.btnElemento.Text = "Elimina";
            this.btnElemento.UseVisualStyleBackColor = true;
            // 
            // lblpos
            // 
            this.lblpos.AutoSize = true;
            this.lblpos.Location = new System.Drawing.Point(243, 412);
            this.lblpos.Name = "lblpos";
            this.lblpos.Size = new System.Drawing.Size(55, 13);
            this.lblpos.TabIndex = 21;
            this.lblpos.Text = "Posizione:";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(318, 407);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(100, 20);
            this.txtPos.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 442);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.lblpos);
            this.Controls.Add(this.btnElemento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtOre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSezione);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.cmbAzienda);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.Classe);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Stagisti";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label Classe;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbAzienda;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.ComboBox cmbSezione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOre;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnElemento;
        private System.Windows.Forms.Label lblpos;
        private System.Windows.Forms.TextBox txtPos;
    }
}

