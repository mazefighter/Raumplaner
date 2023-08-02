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
    public partial class Termin_Erstellen : Form
    {
        private Raum raum;
        private Form1 form;
        public Termin_Erstellen(Raum raum, Form1 form)
        {
            this.raum = raum;
            this.form = form;
            InitializeComponent();
        }

        private void btn_Erstellen_Click(object sender, EventArgs e)
        {
            dtp_Termin.Value = new DateTime(dtp_Termin.Value.Year, dtp_Termin.Value.Month, dtp_Termin.Value.Day, Convert.ToInt32(txt_BeginnStunde.Text), Convert.ToInt32(txt_BeginnMinute.Text),0);
            DateTime dateBeginn = dtp_Termin.Value;
            dtp_Termin.Value = new DateTime(dtp_Termin.Value.Year, dtp_Termin.Value.Month, dtp_Termin.Value.Day, Convert.ToInt32(txt_EndeStunde.Text), Convert.ToInt32(txt_EndeMinute.Text), 0);
            DateTime dateEnd = dtp_Termin.Value;
            foreach(Termin termin in raum.buchungen)
            {
                if(dateBeginn> termin.startdate && dateBeginn < termin.enddate || dateEnd > termin.startdate && dateEnd < termin.enddate|| termin.startdate > dateBeginn && termin.startdate < dateEnd || termin.enddate > dateBeginn && termin.enddate < dateEnd)
                {
                    return;
                }
            }
            if (dateBeginn == dateEnd) return;
            if (dateBeginn.Hour < 8 || dateEnd.Hour > 18) return;
            raum.buchungen.Add(new Termin() { titel = txt_Name.Text, startdate = dateBeginn, enddate = dateEnd, r = lbl_Color.BackColor.R, g = lbl_Color.BackColor.G, b = lbl_Color.BackColor.B });
            form.LadeTermine(raum);

            this.Dispose();
        }

        private void labelColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_Color.BackColor = colorDialog1.Color;
            }
        }

        private void txt_BeginnStunde_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_BeginnMinute.Select();
            }
        }

        private void txt_BeginnMinute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_EndeStunde.Select();
            }
        }

        private void txt_EndeStunde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_EndeMinute.Select();
            }
        }


        private void txt_EndeMinute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Erstellen.Select();
            }
        }

    }
}
