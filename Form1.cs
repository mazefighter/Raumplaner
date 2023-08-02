using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raumplaner
{
    public partial class Form1 : Form
    {
        public List<Raum> räume = new List<Raum>();
        public int ListIndex;
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void anlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raumersteller ersteller = new Raumersteller(this);
            ersteller.Show();
        }

       private void RefreshRäumeList()
        {
            list_Räume.Items.Clear();
            foreach(Raum raum in räume)
            {
                list_Räume.Items.Add(raum.name);
            }
        }

        public void AddToRäumeList(Raum raum)
        {
            räume.Add(raum);
            RefreshRäumeList(); 
        }

        private void list_Räume_SelectedIndexChanged(object sender, EventArgs e)
        {
           ListIndex = list_Räume.SelectedIndex;
            try
            {
                LadeTermine(räume[ListIndex]);
            }
            catch
            {

            }

            
        }
        public void LadeTermine(Raum raum)
        {
            panel1.Controls.Clear();
            int i = 0;
            foreach(Termin termin in raum.buchungen)
            {
                if(termin.Time().Year == dateTimePicker1.Value.Year&& termin.Time().Month == dateTimePicker1.Value.Month && termin.Time().Day == dateTimePicker1.Value.Day)
                {
                    Label lbl = new Label();
                    panel1.Controls.Add(lbl);
                    lbl.Name = "btn_" + i;
                    lbl.Text = termin.titel;
                    lbl.AutoSize = false;
                    lbl.Location = new Point(termin.startDateAsNumber(), 0);
                    lbl.Size = new Size(termin.endDateAsNumber(), 20);
                    lbl.BackColor = termin.color;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                }                           
            }
        }

        private void list_Räume_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Raumansicht raum = new Raumansicht(räume[ListIndex]);
            raum.Text = (sender as Control).Text;
            raum.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LadeTermine(räume[ListIndex]);
        }
     

        private void button_hinzufuegen_Click(object sender, EventArgs e)
        {
            try
            {
                Termin_Erstellen erstellen = new Termin_Erstellen(räume[ListIndex], this);
                erstellen.Show();
            }
            catch
            {
                MessageBox.Show("Lege zuerst einen Raum an");
            }
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {
            try
            {
                Raum tempRaum = räume[ListIndex];
                Raumersteller erstellen = new Raumersteller(this);
                erstellen.SetEverything(tempRaum.bild, tempRaum.name, tempRaum.kapazität.ToString(), tempRaum.tischzahl.ToString(), tempRaum.beamer);
                erstellen.Show();
            }
            catch
            {
                MessageBox.Show("Lege zuerst einen Raum an");
            }
            
            
        }

        private void btn_löschen_Click(object sender, EventArgs e)
        {
            try
            {
                räume.RemoveAt(ListIndex);
                RefreshRäumeList();
            }
            catch
            {
                MessageBox.Show("Lege zuerst einen Raum an");
            }
            
        }

        private void btn_TerminLöschen_Click(object sender, EventArgs e)
        {
            TerminLöschen löschen = new TerminLöschen(räume[ListIndex], this);
            löschen.Show();
        }
    }
}
