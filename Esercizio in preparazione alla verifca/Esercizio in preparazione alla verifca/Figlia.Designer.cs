namespace Esercizio_in_preparazione_alla_verifca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeChild = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognomeChild = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEtaChild = new System.Windows.Forms.TextBox();
            this.btnInviaAForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome ";
            // 
            // txtNomeChild
            // 
            this.txtNomeChild.Location = new System.Drawing.Point(24, 43);
            this.txtNomeChild.Name = "txtNomeChild";
            this.txtNomeChild.Size = new System.Drawing.Size(100, 20);
            this.txtNomeChild.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome ";
            // 
            // txtCognomeChild
            // 
            this.txtCognomeChild.Location = new System.Drawing.Point(24, 98);
            this.txtCognomeChild.Name = "txtCognomeChild";
            this.txtCognomeChild.Size = new System.Drawing.Size(100, 20);
            this.txtCognomeChild.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Età";
            // 
            // txtEtaChild
            // 
            this.txtEtaChild.Location = new System.Drawing.Point(24, 156);
            this.txtEtaChild.Name = "txtEtaChild";
            this.txtEtaChild.Size = new System.Drawing.Size(100, 20);
            this.txtEtaChild.TabIndex = 7;
            // 
            // btnInviaAForm1
            // 
            this.btnInviaAForm1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInviaAForm1.Location = new System.Drawing.Point(166, 96);
            this.btnInviaAForm1.Name = "btnInviaAForm1";
            this.btnInviaAForm1.Size = new System.Drawing.Size(75, 23);
            this.btnInviaAForm1.TabIndex = 8;
            this.btnInviaAForm1.Text = "Invia";
            this.btnInviaAForm1.UseVisualStyleBackColor = true;
            this.btnInviaAForm1.Click += new System.EventHandler(this.BtnInviaAForm1_Click);
            // 
            // Figlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 193);
            this.Controls.Add(this.btnInviaAForm1);
            this.Controls.Add(this.txtEtaChild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognomeChild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeChild);
            this.Controls.Add(this.label1);
            this.Name = "Figlia";
            this.Text = "Figlia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognomeChild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEtaChild;
        private System.Windows.Forms.Button btnInviaAForm1;
    }
}