namespace Raumplaner
{
    partial class Termin_Erstellen
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dtp_Termin = new System.Windows.Forms.DateTimePicker();
            this.txt_BeginnStunde = new System.Windows.Forms.TextBox();
            this.lb_Beginn = new System.Windows.Forms.Label();
            this.lb_Ende = new System.Windows.Forms.Label();
            this.lb_Titel = new System.Windows.Forms.Label();
            this.btn_Erstellen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BeginnMinute = new System.Windows.Forms.TextBox();
            this.txt_EndeMinute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EndeStunde = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(67, 18);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(148, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // dtp_Termin
            // 
            this.dtp_Termin.Location = new System.Drawing.Point(221, 18);
            this.dtp_Termin.Name = "dtp_Termin";
            this.dtp_Termin.Size = new System.Drawing.Size(200, 20);
            this.dtp_Termin.TabIndex = 2;
            // 
            // txt_BeginnStunde
            // 
            this.txt_BeginnStunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BeginnStunde.Location = new System.Drawing.Point(512, 18);
            this.txt_BeginnStunde.Name = "txt_BeginnStunde";
            this.txt_BeginnStunde.Size = new System.Drawing.Size(33, 20);
            this.txt_BeginnStunde.TabIndex = 3;
            this.txt_BeginnStunde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BeginnStunde_KeyDown);
            // 
            // lb_Beginn
            // 
            this.lb_Beginn.AutoSize = true;
            this.lb_Beginn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Beginn.Location = new System.Drawing.Point(427, 15);
            this.lb_Beginn.Name = "lb_Beginn";
            this.lb_Beginn.Size = new System.Drawing.Size(79, 25);
            this.lb_Beginn.TabIndex = 5;
            this.lb_Beginn.Text = "Beginn:";
            // 
            // lb_Ende
            // 
            this.lb_Ende.AutoSize = true;
            this.lb_Ende.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ende.Location = new System.Drawing.Point(618, 15);
            this.lb_Ende.Name = "lb_Ende";
            this.lb_Ende.Size = new System.Drawing.Size(64, 25);
            this.lb_Ende.TabIndex = 6;
            this.lb_Ende.Text = "Ende:";
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.lb_Titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titel.Location = new System.Drawing.Point(12, 15);
            this.lb_Titel.Name = "lb_Titel";
            this.lb_Titel.Size = new System.Drawing.Size(49, 25);
            this.lb_Titel.TabIndex = 7;
            this.lb_Titel.Text = "Titel";
            // 
            // btn_Erstellen
            // 
            this.btn_Erstellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Erstellen.Location = new System.Drawing.Point(339, 57);
            this.btn_Erstellen.Name = "btn_Erstellen";
            this.btn_Erstellen.Size = new System.Drawing.Size(144, 33);
            this.btn_Erstellen.TabIndex = 8;
            this.btn_Erstellen.Text = "Erstellen";
            this.btn_Erstellen.UseVisualStyleBackColor = true;
            this.btn_Erstellen.Click += new System.EventHandler(this.btn_Erstellen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            // 
            // txt_BeginnMinute
            // 
            this.txt_BeginnMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BeginnMinute.Location = new System.Drawing.Point(559, 18);
            this.txt_BeginnMinute.Name = "txt_BeginnMinute";
            this.txt_BeginnMinute.Size = new System.Drawing.Size(33, 20);
            this.txt_BeginnMinute.TabIndex = 10;
            this.txt_BeginnMinute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BeginnMinute_KeyDown);
            // 
            // txt_EndeMinute
            // 
            this.txt_EndeMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EndeMinute.Location = new System.Drawing.Point(735, 18);
            this.txt_EndeMinute.Name = "txt_EndeMinute";
            this.txt_EndeMinute.Size = new System.Drawing.Size(33, 20);
            this.txt_EndeMinute.TabIndex = 13;
            this.txt_EndeMinute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EndeMinute_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = ":";
            // 
            // txt_EndeStunde
            // 
            this.txt_EndeStunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EndeStunde.Location = new System.Drawing.Point(688, 18);
            this.txt_EndeStunde.Name = "txt_EndeStunde";
            this.txt_EndeStunde.Size = new System.Drawing.Size(33, 20);
            this.txt_EndeStunde.TabIndex = 11;
            this.txt_EndeStunde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EndeStunde_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Color";
            // 
            // lbl_Color
            // 
            this.lbl_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_Color.Location = new System.Drawing.Point(51, 57);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(39, 13);
            this.lbl_Color.TabIndex = 15;
            this.lbl_Color.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // Termin_Erstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 102);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_EndeMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_EndeStunde);
            this.Controls.Add(this.txt_BeginnMinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Erstellen);
            this.Controls.Add(this.lb_Titel);
            this.Controls.Add(this.lb_Ende);
            this.Controls.Add(this.lb_Beginn);
            this.Controls.Add(this.txt_BeginnStunde);
            this.Controls.Add(this.dtp_Termin);
            this.Controls.Add(this.txt_Name);
            this.Name = "Termin_Erstellen";
            this.Text = "Termin_Erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DateTimePicker dtp_Termin;
        private System.Windows.Forms.TextBox txt_BeginnStunde;
        private System.Windows.Forms.Label lb_Beginn;
        private System.Windows.Forms.Label lb_Ende;
        private System.Windows.Forms.Label lb_Titel;
        private System.Windows.Forms.Button btn_Erstellen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BeginnMinute;
        private System.Windows.Forms.TextBox txt_EndeMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EndeStunde;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Color;
    }
}