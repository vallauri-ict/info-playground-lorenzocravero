namespace _03_MultiformConMenu
{
    partial class Form2
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
            this.btnValore = new System.Windows.Forms.Button();
            this.btnFormFiglia = new System.Windows.Forms.Button();
            this.btnPassaParametro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValore
            // 
            this.btnValore.Location = new System.Drawing.Point(31, 23);
            this.btnValore.Name = "btnValore";
            this.btnValore.Size = new System.Drawing.Size(87, 32);
            this.btnValore.TabIndex = 0;
            this.btnValore.Text = "Leggi valore";
            this.btnValore.UseVisualStyleBackColor = true;
            this.btnValore.Click += new System.EventHandler(this.BtnValore_Click);
            // 
            // btnFormFiglia
            // 
            this.btnFormFiglia.Location = new System.Drawing.Point(31, 71);
            this.btnFormFiglia.Name = "btnFormFiglia";
            this.btnFormFiglia.Size = new System.Drawing.Size(87, 32);
            this.btnFormFiglia.TabIndex = 1;
            this.btnFormFiglia.Text = "Apri form figlia";
            this.btnFormFiglia.UseVisualStyleBackColor = true;
            this.btnFormFiglia.Click += new System.EventHandler(this.BtnFormFiglia_Click);
            // 
            // btnPassaParametro
            // 
            this.btnPassaParametro.Location = new System.Drawing.Point(31, 109);
            this.btnPassaParametro.Name = "btnPassaParametro";
            this.btnPassaParametro.Size = new System.Drawing.Size(87, 44);
            this.btnPassaParametro.TabIndex = 2;
            this.btnPassaParametro.Text = "Passa parametro";
            this.btnPassaParametro.UseVisualStyleBackColor = true;
            this.btnPassaParametro.Click += new System.EventHandler(this.BtnPassaParametro_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 199);
            this.Controls.Add(this.btnPassaParametro);
            this.Controls.Add(this.btnFormFiglia);
            this.Controls.Add(this.btnValore);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValore;
        private System.Windows.Forms.Button btnFormFiglia;
        private System.Windows.Forms.Button btnPassaParametro;
    }
}