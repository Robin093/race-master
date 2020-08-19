using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FighterJetRace
{
    class playerfactory
    {
        public int startPos { get; set; }
        public int finalPos { get; set; }
        public PictureBox JetImgImg { get; set; }
        private Random rand = new Random();

        // Checks if Jeep is in Motion
        public bool isAccelerating()
        {
            Point updatedLoc = JetImgImg.Location;
            updatedLoc.X += rand.Next(1, 6);
            JetImgImg.Location = updatedLoc;

            // Checks whether the location of right side of Jeep is same as final destination
            if (updatedLoc.X >= finalPos)
                return true;
            else
                return false;
        }

        public void MoveToStart()
        {
            JetImgImg.Left = startPos;
        }
    }
}
