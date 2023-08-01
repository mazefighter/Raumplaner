namespace Raumplaner
{
    partial class Raumersteller
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
            this.lb_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lb_Hinzufügen = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_Kapazität = new System.Windows.Forms.Label();
            this.txt_Kapazität = new System.Windows.Forms.TextBox();
            this.txt_Tischzahl = new System.Windows.Forms.TextBox();
            this.lb_Tischzahl = new System.Windows.Forms.Label();
            this.lb_Beamer = new System.Windows.Forms.Label();
            this.rb_yes = new System.Windows.Forms.RadioButton();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.img_Raum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Raum)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(12, 9);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(69, 25);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Raum:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(87, 9);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 30);
            this.txt_Name.TabIndex = 3;
            // 
            // lb_Hinzufügen
            // 
            this.lb_Hinzufügen.AutoSize = true;
            this.lb_Hinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hinzufügen.Location = new System.Drawing.Point(183, 229);
            this.lb_Hinzufügen.Name = "lb_Hinzufügen";
            this.lb_Hinzufügen.Size = new System.Drawing.Size(267, 25);
            this.lb_Hinzufügen.TabIndex = 5;
            this.lb_Hinzufügen.Text = "Klicken um Bild hinzuzufügen";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(713, 403);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 35);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_Kapazität
            // 
            this.lb_Kapazität.AutoSize = true;
            this.lb_Kapazität.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Kapazität.Location = new System.Drawing.Point(628, 73);
            this.lb_Kapazität.Name = "lb_Kapazität";
            this.lb_Kapazität.Size = new System.Drawing.Size(105, 25);
            this.lb_Kapazität.TabIndex = 7;
            this.lb_Kapazität.Text = "Kapazität: ";
            // 
            // txt_Kapazität
            // 
            this.txt_Kapazität.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Kapazität.Location = new System.Drawing.Point(633, 102);
            this.txt_Kapazität.Name = "txt_Kapazität";
            this.txt_Kapazität.Size = new System.Drawing.Size(100, 30);
            this.txt_Kapazität.TabIndex = 8;
            // 
            // txt_Tischzahl
            // 
            this.txt_Tischzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tischzahl.Location = new System.Drawing.Point(633, 217);
            this.txt_Tischzahl.Name = "txt_Tischzahl";
            this.txt_Tischzahl.Size = new System.Drawing.Size(100, 30);
            this.txt_Tischzahl.TabIndex = 10;
            // 
            // lb_Tischzahl
            // 
            this.lb_Tischzahl.AutoSize = true;
            this.lb_Tischzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tischzahl.Location = new System.Drawing.Point(628, 188);
            this.lb_Tischzahl.Name = "lb_Tischzahl";
            this.lb_Tischzahl.Size = new System.Drawing.Size(107, 25);
            this.lb_Tischzahl.TabIndex = 9;
            this.lb_Tischzahl.Text = "Tischzahl: ";
            // 
            // lb_Beamer
            // 
            this.lb_Beamer.AutoSize = true;
            this.lb_Beamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Beamer.Location = new System.Drawing.Point(633, 296);
            this.lb_Beamer.Name = "lb_Beamer";
            this.lb_Beamer.Size = new System.Drawing.Size(86, 25);
            this.lb_Beamer.TabIndex = 11;
            this.lb_Beamer.Text = "Beamer:";
            // 
            // rb_yes
            // 
            this.rb_yes.AutoSize = true;
            this.rb_yes.Location = new System.Drawing.Point(638, 324);
            this.rb_yes.Name = "rb_yes";
            this.rb_yes.Size = new System.Drawing.Size(36, 17);
            this.rb_yes.TabIndex = 12;
            this.rb_yes.TabStop = true;
            this.rb_yes.Text = "Ja";
            this.rb_yes.UseVisualStyleBackColor = true;
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(678, 324);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(47, 17);
            this.rb_no.TabIndex = 13;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "Nein";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // img_Raum
            // 
            this.img_Raum.Location = new System.Drawing.Point(12, 48);
            this.img_Raum.Name = "img_Raum";
            this.img_Raum.Size = new System.Drawing.Size(610, 390);
            this.img_Raum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Raum.TabIndex = 4;
            this.img_Raum.TabStop = false;
            this.img_Raum.Click += new System.EventHandler(this.img_Raum_Click);
            // 
            // Raumersteller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_no);
            this.Controls.Add(this.rb_yes);
            this.Controls.Add(this.lb_Beamer);
            this.Controls.Add(this.txt_Tischzahl);
            this.Controls.Add(this.lb_Tischzahl);
            this.Controls.Add(this.txt_Kapazität);
            this.Controls.Add(this.lb_Kapazität);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_Hinzufügen);
            this.Controls.Add(this.img_Raum);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lb_Name);
            this.Name = "Raumersteller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.img_Raum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lb_Hinzufügen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_Kapazität;
        private System.Windows.Forms.TextBox txt_Kapazität;
        private System.Windows.Forms.TextBox txt_Tischzahl;
        private System.Windows.Forms.Label lb_Tischzahl;
        private System.Windows.Forms.Label lb_Beamer;
        private System.Windows.Forms.RadioButton rb_yes;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.PictureBox img_Raum;
    }
}