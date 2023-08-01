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
        private List<Raum> räume = new List<Raum>();
        private int ListIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void buchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
        }

        private void list_Räume_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Raumansicht raum = new Raumansicht(räume[ListIndex]);
            raum.Text = (sender as Control).Text;
            raum.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }
    }
}
