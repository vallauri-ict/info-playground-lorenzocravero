namespace Esercizio_di_prova_random
{
    partial class Figlia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtFigliaNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtFigliaCognome = new System.Windows.Forms.TextBox();
            this.lbleta = new System.Windows.Forms.Label();
            this.txtFigliaEta = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtFigliaNome
            // 
            this.txtFigliaNome.Location = new System.Drawing.Point(48, 50);
            this.txtFigliaNome.Name = "txtFigliaNome";
            this.txtFigliaNome.Size = new System.Drawing.Size(100, 20);
            this.txtFigliaNome.TabIndex = 5;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(45, 92);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 6;
            this.lblCognome.Text = "Cognome";
            // 
            // txtFigliaCognome
            // 
            this.txtFigliaCognome.Location = new System.Drawing.Point(48, 108);
            this.txtFigliaCognome.Name = "txtFigliaCognome";
            this.txtFigliaCognome.Size = new System.Drawing.Size(100, 20);
            this.txtFigliaCognome.TabIndex = 7;
            // 
            // lbleta
            // 
            this.lbleta.AutoSize = true;
            this.lbleta.Location = new System.Drawing.Point(45, 145);
            this.lbleta.Name = "lbleta";
            this.lbleta.Size = new System.Drawing.Size(23, 13);
            this.lbleta.TabIndex = 8;
            this.lbleta.Text = "Età";
            // 
            // txtFigliaEta
            // 
            this.txtFigliaEta.Location = new System.Drawing.Point(48, 161);
            this.txtFigliaEta.Name = "txtFigliaEta";
            this.txtFigliaEta.Size = new System.Drawing.Size(100, 20);
            this.txtFigliaEta.TabIndex = 9;
            // 
            // btnInvia
            // 
            this.btnInvia.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInvia.Location = new System.Drawing.Point(175, 87);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 10;
            this.btnInvia.Text = "OK";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.BtnInvia_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(175, 135);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 11;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Figlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 213);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtFigliaEta);
            this.Controls.Add(this.lbleta);
            this.Controls.Add(this.txtFigliaCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtFigliaNome);
            this.Controls.Add(this.label2);
            this.Name = "Figlia";
            this.Text = "Figlia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFigliaNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtFigliaCognome;
        private System.Windows.Forms.Label lbleta;
        private System.Windows.Forms.TextBox txtFigliaEta;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnAnnulla;
    }
}