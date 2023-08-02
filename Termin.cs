using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raumplaner
{
    [Serializable]
    public class Termin
    {
        public DateTime startdate;
        public DateTime enddate;
        public string titel;
        public int r;
        public int g;
        public int b;

        public Termin()
        {
            
        }

        public int startDateAsNumber()
        {
           return ((startdate.Hour - 8) * 60) + startdate.Minute;
        }

        public int endDateAsNumber()
        {
            return (enddate.Hour - startdate.Hour) * 60 + (enddate.Minute - startdate.Minute);
        }

        public DateTime Time()
        {
            return startdate;
        }
    }
}
