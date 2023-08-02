using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raumplaner
{
    public partial class Raumersteller : Form
    {
        private Form1 baseForm;
       
        
        public Raumersteller(Form1 form)
        {
            InitializeComponent();
            baseForm = form;
            
        }
     

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (baseForm.räume.Count == 0)
                {
                    Raum raumNeu = new Raum(img_Raum.Image, txt_Name.Text, Convert.ToInt32(txt_Kapazität.Text), Convert.ToInt32(txt_Tischzahl.Text), false);
                    if (rb_no.Checked) raumNeu.beamer = false;
                    if (rb_yes.Checked) raumNeu.beamer = true;
                    baseForm.AddToRäumeList(raumNeu);
                    this.Dispose();
                }
                else
                {
                    foreach (Raum raum in baseForm.räume)
                    {
                        if (txt_Name.Text == raum.name)
                        {
                            raum.neueWerte(img_Raum.Image, txt_Name.Text, Convert.ToInt32(txt_Kapazität.Text), Convert.ToInt32(txt_Tischzahl.Text), false);
                            if (rb_no.Checked) raum.beamer = false;
                            if (rb_yes.Checked) raum.beamer = true;
                            this.Dispose();
                            return;
                        }
                    }
                    Raum raumNeu = new Raum(img_Raum.Image, txt_Name.Text, Convert.ToInt32(txt_Kapazität.Text), Convert.ToInt32(txt_Tischzahl.Text), false);
                    if (rb_no.Checked) raumNeu.beamer = false;
                    if (rb_yes.Checked) raumNeu.beamer = true;
                    baseForm.AddToRäumeList(raumNeu);
                    this.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Bitte Fülle alle Felder aus");
            }
            
        }

        private void img_Raum_Click(object sender, EventArgs e)
        {
          DialogResult result =  openFileDialog.ShowDialog();

            try
            {
                img_Raum.Image = Image.FromFile(openFileDialog.FileName);
                lb_Hinzufügen.Visible = false;
            }
            catch
            {
                openFileDialog.Dispose();
            }
            
        }

        public void SetEverything(Image img,string name, string kapazität, string tischzahl, bool beamer)
        {
            txt_Name.Text = name;
            txt_Name.Enabled = false;
            txt_Kapazität.Text = kapazität;
            txt_Tischzahl.Text = tischzahl;
            img_Raum.Image=img;
            if (beamer) rb_yes.Checked = true; else rb_no.Checked = true;
            lb_Hinzufügen.Visible = false;
        }

    }
}
