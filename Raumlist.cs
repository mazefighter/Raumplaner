using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raumplaner
{
    [Serializable]
   public class Raumlist
    {
        public List<Raum> räume;

        public Raumlist()
        {
            räume = new List<Raum>();
        }
    }
}
