using System;
using System.Windows.Forms;

namespace Day_at_the_Races
{
    class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randmizer;

        public bool Run()
        {
            Location += Randmizer.Next(1,10);
            MyPictureBox.Left = StartingPosition+ Location;
            if (MyPictureBox.Left > RacetrackLength)
                return true;
            else
                return false;
        }
        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
