using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterJetRace
{
    abstract class Data
    {
        public static playerfactory[] jet = new playerfactory[4];
        public static better[] bettor = new better[3];
        public static Random rand = new Random();
        public static int currentGambler { get; set; }
    }
}
