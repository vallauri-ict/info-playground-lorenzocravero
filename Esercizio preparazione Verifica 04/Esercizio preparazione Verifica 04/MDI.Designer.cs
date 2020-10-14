namespace Esercizio_preparazione_Verifica_04
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voce1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voce2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voce3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voce1ToolStripMenuItem,
            this.voce2ToolStripMenuItem,
            this.voce3ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // voce1ToolStripMenuItem
            // 
            this.voce1ToolStripMenuItem.Name = "voce1ToolStripMenuItem";
            this.voce1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voce1ToolStripMenuItem.Text = "Voce1";
            this.voce1ToolStripMenuItem.Click += new System.EventHandler(this.voce1ToolStripMenuItem_Click);
            // 
            // voce2ToolStripMenuItem
            // 
            this.voce2ToolStripMenuItem.Name = "voce2ToolStripMenuItem";
            this.voce2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voce2ToolStripMenuItem.Text = "Voce2";
            this.voce2ToolStripMenuItem.Click += new System.EventHandler(this.voce2ToolStripMenuItem_Click);
            // 
            // voce3ToolStripMenuItem
            // 
            this.voce3ToolStripMenuItem.Name = "voce3ToolStripMenuItem";
            this.voce3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voce3ToolStripMenuItem.Text = "Voce3";
            this.voce3ToolStripMenuItem.Click += new System.EventHandler(this.voce3ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(282, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 248);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voce1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voce2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voce3ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}