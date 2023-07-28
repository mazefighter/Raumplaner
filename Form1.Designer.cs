namespace Raumplaner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Raum208 = new System.Windows.Forms.Button();
            this.btn_207 = new System.Windows.Forms.Button();
            this.list_Räume = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buchenToolStripMenuItem,
            this.übersichtToolStripMenuItem,
            this.anlegenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.menuToolStripMenuItem.Text = "Räume";
            // 
            // buchenToolStripMenuItem
            // 
            this.buchenToolStripMenuItem.Name = "buchenToolStripMenuItem";
            this.buchenToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.buchenToolStripMenuItem.Text = "Termin hinzufügen/löschen";
            this.buchenToolStripMenuItem.Click += new System.EventHandler(this.buchenToolStripMenuItem_Click);
            // 
            // übersichtToolStripMenuItem
            // 
            this.übersichtToolStripMenuItem.Name = "übersichtToolStripMenuItem";
            this.übersichtToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.übersichtToolStripMenuItem.Text = "Übersicht";
            // 
            // anlegenToolStripMenuItem
            // 
            this.anlegenToolStripMenuItem.Name = "anlegenToolStripMenuItem";
            this.anlegenToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.anlegenToolStripMenuItem.Text = "Anlegen";
            this.anlegenToolStripMenuItem.Click += new System.EventHandler(this.anlegenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // btn_Raum208
            // 
            this.btn_Raum208.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Raum208.Location = new System.Drawing.Point(240, 89);
            this.btn_Raum208.Name = "btn_Raum208";
            this.btn_Raum208.Size = new System.Drawing.Size(100, 50);
            this.btn_Raum208.TabIndex = 2;
            this.btn_Raum208.Text = "Raum 2.0.8";
            this.btn_Raum208.UseVisualStyleBackColor = true;
            this.btn_Raum208.Click += new System.EventHandler(this.btn_Raum208_Click);
            // 
            // btn_207
            // 
            this.btn_207.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_207.Location = new System.Drawing.Point(92, 89);
            this.btn_207.Name = "btn_207";
            this.btn_207.Size = new System.Drawing.Size(100, 50);
            this.btn_207.TabIndex = 1;
            this.btn_207.Text = "Raum 2.0.7";
            this.btn_207.UseVisualStyleBackColor = true;
            this.btn_207.Click += new System.EventHandler(this.btn_Raum207_Click);
            // 
            // list_Räume
            // 
            this.list_Räume.FormattingEnabled = true;
            this.list_Räume.Location = new System.Drawing.Point(317, 188);
            this.list_Räume.Name = "list_Räume";
            this.list_Räume.Size = new System.Drawing.Size(120, 95);
            this.list_Räume.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_Räume);
            this.Controls.Add(this.btn_Raum208);
            this.Controls.Add(this.btn_207);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.Button btn_Raum208;
        private System.Windows.Forms.Button btn_207;
        private System.Windows.Forms.ListBox list_Räume;
    }
}

