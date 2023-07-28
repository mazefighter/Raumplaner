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
        public Form1()
        {
            InitializeComponent();
        }

        private void buchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Raum207_Click(object sender, EventArgs e)
        {
            Raumansicht raum = new Raumansicht();
            raum.Text = (sender as Control).Text;
            raum.Show();
            raum.Raumbild.Image = Properties.Resources.Raum_2_0_7;
            raum.Raumname.Text = (sender as Control).Text;
        }

        private void btn_Raum208_Click(object sender, EventArgs e)
        {
            Raumansicht raum = new Raumansicht();
            raum.Text = (sender as Control).Text;
            raum.Show();
            raum.Raumbild.Image = Properties.Resources.Raum_2_0_8;
            raum.Raumname.Text = (sender as Control).Text;
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
    }
}
