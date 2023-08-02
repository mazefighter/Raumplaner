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
    public partial class TerminLöschen : Form
    {
        private Raum raum;
        private Form1 form;
        public TerminLöschen(Raum raum, Form1 baseForm)
        {
            InitializeComponent();
            this.raum = raum;
            form = baseForm;
            foreach(Termin termin in raum.buchungen)
            {                
                list_Termine.Items.Add(termin.titel);
            }
            
        }

        private void btn_löschen_Click(object sender, EventArgs e)
        {
            raum.buchungen.RemoveAt(list_Termine.SelectedIndex);
            form.LadeTermine(form.raumlist.räume[form.ListIndex]);
            this.Dispose();
        }
    }
}
