namespace Bibly
{
    partial class FrmOpcenita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpcenita));
            this.glavniMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.glavniMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // glavniMenu
            // 
            this.glavniMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(159)))), ((int)(((byte)(181)))));
            this.glavniMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.glavniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOdjava});
            this.glavniMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.glavniMenu.Location = new System.Drawing.Point(0, 0);
            this.glavniMenu.Name = "glavniMenu";
            this.glavniMenu.Size = new System.Drawing.Size(1080, 29);
            this.glavniMenu.TabIndex = 0;
            this.glavniMenu.Text = "menuStrip1";
            // 
            // tsmiOdjava
            // 
            this.tsmiOdjava.Name = "tsmiOdjava";
            this.tsmiOdjava.Size = new System.Drawing.Size(71, 25);
            this.tsmiOdjava.Text = "Odjava";
            this.tsmiOdjava.Click += new System.EventHandler(this.tsmiOdjava_Click);
            // 
            // OpcenitaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1080, 605);
            this.Controls.Add(this.glavniMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.glavniMenu;
            this.Name = "OpcenitaForma";
            this.Text = "OpcenitaForma";
            this.glavniMenu.ResumeLayout(false);
            this.glavniMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip glavniMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiOdjava;
    }
}

