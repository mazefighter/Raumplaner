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
        public Raumansicht()
        {
            InitializeComponent();
        }

        
    }
}
