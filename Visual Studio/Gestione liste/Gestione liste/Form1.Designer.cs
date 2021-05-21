namespace Gestione_liste
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.txtFindLibro = new System.Windows.Forms.TextBox();
            this.txtFindAutore = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(70, 6);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autore";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(70, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(70, 40);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 5;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(15, 125);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(97, 23);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi libro";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(135, 125);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(97, 23);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "Visualizza catalogo";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.BtnVisualizza_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(15, 171);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(15, 215);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(97, 23);
            this.btnFindAll.TabIndex = 9;
            this.btnFindAll.Text = "FindAll";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.BtnFindAll_Click);
            // 
            // txtFindLibro
            // 
            this.txtFindLibro.Location = new System.Drawing.Point(135, 171);
            this.txtFindLibro.Name = "txtFindLibro";
            this.txtFindLibro.Size = new System.Drawing.Size(100, 20);
            this.txtFindLibro.TabIndex = 10;
            // 
            // txtFindAutore
            // 
            this.txtFindAutore.Location = new System.Drawing.Point(135, 215);
            this.txtFindAutore.Name = "txtFindAutore";
            this.txtFindAutore.Size = new System.Drawing.Size(100, 20);
            this.txtFindAutore.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aggiungi libro Object";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Visualizza Object";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Trova libro ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(390, 212);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(120, 20);
            this.txtIndice.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Carica dictionary";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Visualizza dictionary";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 289);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFindAutore);
            this.Controls.Add(this.txtFindLibro);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.TextBox txtFindLibro;
        private System.Windows.Forms.TextBox txtFindAutore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

