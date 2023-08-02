namespace Raumplaner
{
    partial class TerminLöschen
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
            this.list_Termine = new System.Windows.Forms.ListBox();
            this.btn_löschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Termine
            // 
            this.list_Termine.FormattingEnabled = true;
            this.list_Termine.Location = new System.Drawing.Point(13, 13);
            this.list_Termine.Name = "list_Termine";
            this.list_Termine.Size = new System.Drawing.Size(120, 95);
            this.list_Termine.TabIndex = 0;
            // 
            // btn_löschen
            // 
            this.btn_löschen.Location = new System.Drawing.Point(140, 49);
            this.btn_löschen.Name = "btn_löschen";
            this.btn_löschen.Size = new System.Drawing.Size(75, 23);
            this.btn_löschen.TabIndex = 1;
            this.btn_löschen.Text = "Löschen";
            this.btn_löschen.UseVisualStyleBackColor = true;
            this.btn_löschen.Click += new System.EventHandler(this.btn_löschen_Click);
            // 
            // TerminLöschen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 132);
            this.Controls.Add(this.btn_löschen);
            this.Controls.Add(this.list_Termine);
            this.Name = "TerminLöschen";
            this.Text = "TerminLöschen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_Termine;
        private System.Windows.Forms.Button btn_löschen;
    }
}