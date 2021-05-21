namespace _03_MultiformConMenu
{
    partial class Form3
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
            this.btnLeggiValore2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeggiValore2
            // 
            this.btnLeggiValore2.Location = new System.Drawing.Point(47, 47);
            this.btnLeggiValore2.Name = "btnLeggiValore2";
            this.btnLeggiValore2.Size = new System.Drawing.Size(93, 38);
            this.btnLeggiValore2.TabIndex = 0;
            this.btnLeggiValore2.Text = "Leggi valore";
            this.btnLeggiValore2.UseVisualStyleBackColor = true;
            this.btnLeggiValore2.Click += new System.EventHandler(this.BtnLeggiValore2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 194);
            this.Controls.Add(this.btnLeggiValore2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeggiValore2;
    }
}