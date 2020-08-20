using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterJetRace
{
    class PlaceBet : playerfactory
    {
        public int BetAmount { get; set; }
        public better gambler { get; set; }
        public int jet { get; set; }
        public int rewardMultiplier = 4;

        public int CashOut(int winningJet)
        {
            if (winningJet == jet)
                return BetAmount * rewardMultiplier;
            else
                return (0 - BetAmount);
        }
    }
}
