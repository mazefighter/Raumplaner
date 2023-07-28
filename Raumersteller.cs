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
            baseForm.AddToRäumeList(new Raum(Properties.Resources.Raum_2_0_7, "Raum 2.0.7", 4, 2, true));
            this.Dispose();
        }

        private void img_Raum_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
    }
}
