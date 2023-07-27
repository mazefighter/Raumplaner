namespace Raumplaner
{
    partial class Räume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Räume));
            this.img_Raum = new System.Windows.Forms.PictureBox();
            this.lb_Raum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Raum)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Raum
            // 
            this.img_Raum.Image = ((System.Drawing.Image)(resources.GetObject("img_Raum.Image")));
            this.img_Raum.Location = new System.Drawing.Point(12, 48);
            this.img_Raum.Name = "img_Raum";
            this.img_Raum.Size = new System.Drawing.Size(610, 390);
            this.img_Raum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Raum.TabIndex = 0;
            this.img_Raum.TabStop = false;
            // 
            // lb_Raum
            // 
            this.lb_Raum.AutoSize = true;
            this.lb_Raum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Raum.Location = new System.Drawing.Point(12, 9);
            this.lb_Raum.Name = "lb_Raum";
            this.lb_Raum.Size = new System.Drawing.Size(69, 25);
            this.lb_Raum.TabIndex = 1;
            this.lb_Raum.Text = "Raum:";
            // 
            // Räume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Raum);
            this.Controls.Add(this.img_Raum);
            this.Name = "Räume";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.img_Raum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Raum;
        private System.Windows.Forms.Label lb_Raum;
    }
}