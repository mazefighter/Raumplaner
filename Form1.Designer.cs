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
            this.anlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list_Räume = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_hinzufügen = new System.Windows.Forms.Button();
            this.btn_löschen = new System.Windows.Forms.Button();
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.btn_TerminLöschen = new System.Windows.Forms.Button();
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
            this.anlegenToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.menuToolStripMenuItem.Text = "Räume";
            // 
            // anlegenToolStripMenuItem
            // 
            this.anlegenToolStripMenuItem.Name = "anlegenToolStripMenuItem";
            this.anlegenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.anlegenToolStripMenuItem.Text = "Anlegen";
            this.anlegenToolStripMenuItem.Click += new System.EventHandler(this.anlegenToolStripMenuItem_Click);
            // 
            // list_Räume
            // 
            this.list_Räume.FormattingEnabled = true;
            this.list_Räume.Location = new System.Drawing.Point(0, 27);
            this.list_Räume.Name = "list_Räume";
            this.list_Räume.Size = new System.Drawing.Size(120, 160);
            this.list_Räume.TabIndex = 3;
            this.list_Räume.SelectedIndexChanged += new System.EventHandler(this.list_Räume_SelectedIndexChanged);
            this.list_Räume.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_Räume_MouseDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Enabled = false;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(128, 86);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(660, 29);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "8:00";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "9:00";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "10:00";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "11:00";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "12:00";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "13:00";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "14:00";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "15:00";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "16:00";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "17:00";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "18:00";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(128, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 20);
            this.panel1.TabIndex = 6;
            // 
            // btn_hinzufügen
            // 
            this.btn_hinzufügen.Location = new System.Drawing.Point(128, 156);
            this.btn_hinzufügen.Name = "btn_hinzufügen";
            this.btn_hinzufügen.Size = new System.Drawing.Size(109, 23);
            this.btn_hinzufügen.TabIndex = 7;
            this.btn_hinzufügen.Text = "Termin hinzufügen";
            this.btn_hinzufügen.UseVisualStyleBackColor = true;
            this.btn_hinzufügen.Click += new System.EventHandler(this.button_hinzufuegen_Click);
            // 
            // btn_löschen
            // 
            this.btn_löschen.Location = new System.Drawing.Point(679, 156);
            this.btn_löschen.Name = "btn_löschen";
            this.btn_löschen.Size = new System.Drawing.Size(109, 23);
            this.btn_löschen.TabIndex = 8;
            this.btn_löschen.Text = "Raum löschen";
            this.btn_löschen.UseVisualStyleBackColor = true;
            this.btn_löschen.Click += new System.EventHandler(this.btn_löschen_Click);
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.Location = new System.Drawing.Point(564, 156);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(109, 23);
            this.btn_bearbeiten.TabIndex = 9;
            this.btn_bearbeiten.Text = "Raum bearbeiten";
            this.btn_bearbeiten.UseVisualStyleBackColor = true;
            this.btn_bearbeiten.Click += new System.EventHandler(this.btn_bearbeiten_Click);
            // 
            // btn_TerminLöschen
            // 
            this.btn_TerminLöschen.Location = new System.Drawing.Point(243, 156);
            this.btn_TerminLöschen.Name = "btn_TerminLöschen";
            this.btn_TerminLöschen.Size = new System.Drawing.Size(109, 23);
            this.btn_TerminLöschen.TabIndex = 10;
            this.btn_TerminLöschen.Text = "Termin löschen";
            this.btn_TerminLöschen.UseVisualStyleBackColor = true;
            this.btn_TerminLöschen.Click += new System.EventHandler(this.btn_TerminLöschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 191);
            this.Controls.Add(this.btn_TerminLöschen);
            this.Controls.Add(this.btn_bearbeiten);
            this.Controls.Add(this.btn_löschen);
            this.Controls.Add(this.btn_hinzufügen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.list_Räume);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anlegenToolStripMenuItem;
        private System.Windows.Forms.ListBox list_Räume;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_hinzufügen;
        private System.Windows.Forms.Button btn_löschen;
        private System.Windows.Forms.Button btn_bearbeiten;
        private System.Windows.Forms.Button btn_TerminLöschen;
    }
}

