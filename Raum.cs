using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raumplaner
{
    [Serializable]
    public class Raum
    {
        public string path;
        public string name;
        public int kapazität;
        public int tischzahl;
        public bool beamer;

        public List<Termin> buchungen = new List<Termin>();
        public Raum() 
        { 
                       
        }


        public void neueWerte(string RaumBildPath, string Raumname, int Kapazität, int Tischzahl, bool Beamer)
        {
            path = RaumBildPath;
            name = Raumname;
            kapazität = Kapazität;
            tischzahl = Tischzahl;
            beamer = Beamer;
        }

        

       
    }
}
