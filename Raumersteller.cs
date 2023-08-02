using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Raumplaner
{
    public partial class Raumersteller : Form
    {
        
        private Form1 baseForm;
        private string imgPath;
       
        
        public Raumersteller(Form1 form)
        {
            InitializeComponent();
            baseForm = form;
            
        }
     

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (baseForm.raumlist.räume.Count == 0)
                {
                    Raum raumNeu = new Raum()
                    {
                        path = imgPath,
                        name = txt_Name.Text,
                        kapazität = Convert.ToInt32(txt_Kapazität.Text),
                        tischzahl = Convert.ToInt32(txt_Tischzahl.Text),
                        beamer = false
                    };
                    if (rb_no.Checked) raumNeu.beamer = false;
                    if (rb_yes.Checked) raumNeu.beamer = true;
                    baseForm.AddToRäumeList(raumNeu);
                    this.Dispose();
                }
                else
                {
                    foreach (Raum raum in baseForm.raumlist.räume)
                    {
                        if (txt_Name.Text == raum.name)
                        {
                            raum.neueWerte(imgPath, txt_Name.Text, Convert.ToInt32(txt_Kapazität.Text), Convert.ToInt32(txt_Tischzahl.Text), false);
                            if (rb_no.Checked) raum.beamer = false;
                            if (rb_yes.Checked) raum.beamer = true;
                            this.Dispose();
                            return;
                        }
                    }
                    Raum raumNeu = new Raum()
                    {
                        path = imgPath,
                        name = txt_Name.Text,
                        kapazität = Convert.ToInt32(txt_Kapazität.Text),
                        tischzahl = Convert.ToInt32(txt_Tischzahl.Text),
                        beamer = false
                    };
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

            
                imgPath = System.Environment.CurrentDirectory + "\\Bilder\\" + txt_Name.Text + ".png";
                System.IO.File.Copy(openFileDialog.FileName, imgPath, true );
                img_Raum.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Bilder\\" + txt_Name.Text + ".png");
                lb_Hinzufügen.Visible = false;

            
            
        }

        public void SetEverything(string imgpath,string name, string kapazität, string tischzahl, bool beamer)
        {
            txt_Name.Text = name;
            txt_Name.Enabled = false;
            txt_Kapazität.Text = kapazität;
            txt_Tischzahl.Text = tischzahl;
            img_Raum.Image=Image.FromFile(imgpath);
            if (beamer) rb_yes.Checked = true; else rb_no.Checked = true;
            lb_Hinzufügen.Visible = false;
        }

        
    }
}
