using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raumplaner
{
    public class Termin
    {
        public DateTime startdate;
        public DateTime enddate;
        public string titel;
        public Color color;

        public Termin(string titel,DateTime startdate, DateTime enddate, Color color)
        {
            this.startdate = startdate;
            this.enddate = enddate;
            this.titel = titel;
            this.color = color;
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
