using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program25
{
    class Song
    {
        public string title;
        public string band;
        public int duration;
        public static int songCount = 0;
        public Song(string aTitle, string aBand, int aDuration) 
        {
            title = aTitle;
            band = aBand;
            duration = aDuration;
            songCount++;
        }

    }
}
