namespace Esercizio_in_preparazione_alla_verifca
{
    partial class Terza
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
            this.btnModificaTerza = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModificaTerza
            // 
            this.btnModificaTerza.Location = new System.Drawing.Point(25, 34);
            this.btnModificaTerza.Name = "btnModificaTerza";
            this.btnModificaTerza.Size = new System.Drawing.Size(75, 23);
            this.btnModificaTerza.TabIndex = 0;
            this.btnModificaTerza.Text = "Modifica";
            this.btnModificaTerza.UseVisualStyleBackColor = true;
            this.btnModificaTerza.Click += new System.EventHandler(this.BtnModificaTerza_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Terza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 163);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModificaTerza);
            this.Name = "Terza";
            this.Text = "Terza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificaTerza;
        private System.Windows.Forms.TextBox textBox1;
    }
}