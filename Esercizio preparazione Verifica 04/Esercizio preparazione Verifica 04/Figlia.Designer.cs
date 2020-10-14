namespace Esercizio_preparazione_Verifica_04
{
    partial class btnRicevi
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
            this.txtModificaFiglia = new System.Windows.Forms.TextBox();
            this.btnModificaFiglia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModificaFiglia
            // 
            this.txtModificaFiglia.Location = new System.Drawing.Point(94, 104);
            this.txtModificaFiglia.Name = "txtModificaFiglia";
            this.txtModificaFiglia.Size = new System.Drawing.Size(100, 20);
            this.txtModificaFiglia.TabIndex = 5;
            // 
            // btnModificaFiglia
            // 
            this.btnModificaFiglia.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModificaFiglia.Location = new System.Drawing.Point(62, 42);
            this.btnModificaFiglia.Name = "btnModificaFiglia";
            this.btnModificaFiglia.Size = new System.Drawing.Size(75, 29);
            this.btnModificaFiglia.TabIndex = 6;
            this.btnModificaFiglia.Text = "Modifica";
            this.btnModificaFiglia.UseVisualStyleBackColor = true;
            this.btnModificaFiglia.Click += new System.EventHandler(this.btnModificaFiglia_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(162, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ricevi modifica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRicevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificaFiglia);
            this.Controls.Add(this.txtModificaFiglia);
            this.Name = "btnRicevi";
            this.Text = "Figlia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtModificaFiglia;
        private System.Windows.Forms.Button btnModificaFiglia;
        private System.Windows.Forms.Button button1;
    }
}