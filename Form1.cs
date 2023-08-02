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
using System.Xml.Serialization;
using System.IO;

namespace Raumplaner
{
    public partial class Form1 : Form
    {       

        public int ListIndex;
        public Raumlist raumlist = new Raumlist();

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
            foreach(Raum raum in raumlist.räume)
            {
                list_Räume.Items.Add(raum.name);
            }
        }

        public void AddToRäumeList(Raum raum)
        {
            raumlist.räume.Add(raum);
            RefreshRäumeList(); 
        }

        private void list_Räume_SelectedIndexChanged(object sender, EventArgs e)
        {
           ListIndex = list_Räume.SelectedIndex;
            try
            {
                LadeTermine(raumlist.räume[ListIndex]);
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
                    lbl.Name = "btn_" + i;
                    lbl.Text = termin.titel;
                    lbl.AutoSize = false;
                    lbl.Location = new Point(termin.startDateAsNumber(), 0);
                    lbl.Size = new Size(termin.endDateAsNumber(), 20);
                    lbl.BackColor = Color.FromArgb(termin.r,termin.g,termin.b);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    panel1.Controls.Add(lbl);
                }                           
            }
        }

        private void list_Räume_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Raumansicht raum = new Raumansicht(raumlist.räume[ListIndex]);
            raum.Text = (sender as Control).Text;
            raum.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LadeTermine(raumlist.räume[ListIndex]);
        }
     

        private void button_hinzufuegen_Click(object sender, EventArgs e)
        {
            try
            {
                Termin_Erstellen erstellen = new Termin_Erstellen(raumlist.räume[ListIndex], this);
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
                Raum tempRaum = raumlist.räume[ListIndex];
                Raumersteller erstellen = new Raumersteller(this);
                erstellen.SetEverything(tempRaum.path, tempRaum.name, tempRaum.kapazität.ToString(), tempRaum.tischzahl.ToString(), tempRaum.beamer);
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
                raumlist.räume.RemoveAt(ListIndex);
                RefreshRäumeList();
            }
            catch
            {
                MessageBox.Show("Lege zuerst einen Raum an");
            }
            
        }

        private void btn_TerminLöschen_Click(object sender, EventArgs e)
        {
            TerminLöschen löschen = new TerminLöschen(raumlist.räume[ListIndex], this);
            löschen.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("save.txt")) return;
            var serializer = new XmlSerializer(typeof(Raumlist));
            var stream = new FileStream("save.txt", FileMode.Open);
            raumlist = serializer.Deserialize(stream) as Raumlist;
            stream.Close();
            RefreshRäumeList();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Raumlist));
            var stream = new FileStream("save.txt", FileMode.Create);
            xmlSerializer.Serialize(stream, raumlist);
            stream.Close();
        }
    }
}
