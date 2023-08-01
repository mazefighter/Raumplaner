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
    public partial class Raumansicht : Form
    {
        public PictureBox Raumbild => img_Raum;
        public Label Raumname => lb_Raum;
        public Raumansicht(Raum raum)
        {
            InitializeComponent();
            lb_showRaum.Text = raum.name;
            lb_showKapazität.Text = raum.kapazität.ToString();
            lb_showTischzahl.Text = raum.tischzahl.ToString();
            if (raum.beamer)
            {
                lb_showBeamer.Text = "Ja";
            }
            else
            {
                lb_showBeamer.Text = "Nein";
            }
            img_Raum.Image = raum.bild;
        }


    }
}
