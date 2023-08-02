using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raumplaner
{
    public class Raum
    {
        public Image bild;
        public string name;
        public int kapazität;
        public int tischzahl;
        public bool beamer;

        public List<Termin> buchungen = new List<Termin>();
        public Raum(Image RaumBild, string Raumname, int Kapazität, int Tischzahl, bool Beamer) 
        { 
            bild = RaumBild;
            name = Raumname;
            kapazität = Kapazität;
            tischzahl = Tischzahl;
            beamer = Beamer;
        }
    }
}
