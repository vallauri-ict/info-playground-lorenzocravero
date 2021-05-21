namespace _03_MultiformConMenu
{
    partial class FormFiglia
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
            this.btnFigliaDiChi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFigliaDiChi
            // 
            this.btnFigliaDiChi.Location = new System.Drawing.Point(37, 43);
            this.btnFigliaDiChi.Name = "btnFigliaDiChi";
            this.btnFigliaDiChi.Size = new System.Drawing.Size(89, 35);
            this.btnFigliaDiChi.TabIndex = 0;
            this.btnFigliaDiChi.Text = "Figlia di chi";
            this.btnFigliaDiChi.UseVisualStyleBackColor = true;
            this.btnFigliaDiChi.Click += new System.EventHandler(this.BtnFigliaDiChi_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 171);
            this.Controls.Add(this.btnFigliaDiChi);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFigliaDiChi;
    }
}