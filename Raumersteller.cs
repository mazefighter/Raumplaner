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
            Raum raumNeu = new Raum(img_Raum.Image, txt_Name.Text, Convert.ToInt32(txt_Kapazität.Text), Convert.ToInt32(txt_Tischzahl.Text), false);          
            if (rb_no.Checked) raumNeu.beamer = false;
            if (rb_yes.Checked) raumNeu.beamer = true;
            baseForm.AddToRäumeList(raumNeu);
            this.Dispose();
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

    }
}
