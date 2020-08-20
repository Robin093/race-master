using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FighterJetRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Setup Defaults
            setup();
        }

        // Setup all the base elements for the race
        public void setup()
        {
            // Get's the start position
            int startPos = jetBlack.Left;

            // Calculates the length of the race track
            int RaceTrackLength = TrackLengthPanel.Width - jetBlack.Right;

            // Initializes all the racing vehicles
            Data.jet[0] = new playerfactory() { JetImgImg = jetBlack, startPos = startPos, finalPos = RaceTrackLength };
            Data.jet[1] = new playerfactory() { JetImgImg = jetBlue, startPos = startPos, finalPos = RaceTrackLength };
            Data.jet[2] = new playerfactory() { JetImgImg = JetYellow, startPos = startPos, finalPos = RaceTrackLength };
            Data.jet[3] = new playerfactory() { JetImgImg = JetRed, startPos = startPos, finalPos = RaceTrackLength };

            // Initialize all the gamblers
            Data.bettor[0] = new better() { balance = 65, activity = label1, listOfBettors = radioButton1, name = "Player 1" };
            Data.bettor[1] = new better() { balance = 75, activity = label2, listOfBettors = radioButton2, name = "Player 2" };
            Data.bettor[2] = new better() { balance = 55, activity = label3, listOfBettors = radioButton3, name = "Player 3" };

            // Update all the activity labels to default
            Data.bettor[0].UpdateActivity();
            Data.bettor[1].UpdateActivity();
            Data.bettor[2].UpdateActivity();

            // Reset all the starts to defaults
            Data.bettor[0].ResetStats();
            Data.bettor[1].ResetStats();
            Data.bettor[2].ResetStats();
        }

        public void ResetPositions()
        {
            Data.jet[0].MoveToStart();
            Data.jet[1].MoveToStart();
            Data.jet[2].MoveToStart();
            Data.jet[3].MoveToStart();
        }

        public void ResetBidsText()
        {
            label1.Text = "Player 1 hasn't placed a bit.";
            label2.Text = "Player 2 hasn't placed a bit.";
            label3.Text = "Player 3 hasn't placed a bit.";
        }

        public void announceWinner(int winner)
        {
            MessageBox.Show("Knight #" + winner + " is the winning Knight!");
            for (int i = 0; i < Data.bettor.Length; i++)
            {
                Data.bettor[i].collectWinningAmount(winner);
                Data.bettor[i].UpdateActivity();
                ResetPositions();
                ResetBidsText();
            }
        }

        private void StartRace_Click(object sender, EventArgs e)
        {
            RaceTimer.Start();
            StartRace.Enabled = false;
        }

        private void PlaceBet_Click(object sender, EventArgs e)
        {
            Data.bettor[Data.currentGambler].betting((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Data.bettor[Data.currentGambler].UpdateActivity();
        }

        private void RaceTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.jet.Length; i++)
            {
                Data.jet[Data.rand.Next(0, 4)].isAccelerating();
                if (Data.jet[i].isAccelerating())
                {
                    RaceTimer.Stop();
                    RaceTimer.Enabled = false;
                    StartRace.Enabled = true;
                    announceWinner(i + 1);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 2;
        }
    }
}
