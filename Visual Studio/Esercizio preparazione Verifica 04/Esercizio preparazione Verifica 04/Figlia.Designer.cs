namespace Esercizio_preparazione_Verifica_04
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
            this.btnPassaPapa = new System.Windows.Forms.Button();
            this.txtFiglia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPassaPapa
            // 
            this.btnPassaPapa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPassaPapa.Location = new System.Drawing.Point(45, 65);
            this.btnPassaPapa.Name = "btnPassaPapa";
            this.btnPassaPapa.Size = new System.Drawing.Size(75, 40);
            this.btnPassaPapa.TabIndex = 0;
            this.btnPassaPapa.Text = "Passa a form1";
            this.btnPassaPapa.UseVisualStyleBackColor = true;
            this.btnPassaPapa.Click += new System.EventHandler(this.btnPassaPapa_Click);
            // 
            // txtFiglia
            // 
            this.txtFiglia.Location = new System.Drawing.Point(32, 39);
            this.txtFiglia.Name = "txtFiglia";
            this.txtFiglia.Size = new System.Drawing.Size(100, 20);
            this.txtFiglia.TabIndex = 1;
            // 
            // Figlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 137);
            this.Controls.Add(this.txtFiglia);
            this.Controls.Add(this.btnPassaPapa);
            this.Name = "Figlia";
            this.Text = "Figlia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPassaPapa;
        private System.Windows.Forms.TextBox txtFiglia;
    }
}