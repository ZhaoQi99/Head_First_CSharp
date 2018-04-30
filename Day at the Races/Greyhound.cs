using System;
using System.Windows.Forms;

namespace Day_at_the_Races
{
    class Greyhound
    {
        public int StartingPosition;//Where my PictureBox starts
        public int RacetrackLength;//How long the racetrack is
        public PictureBox MyPictureBox = null;//My pictureBox object
        public int Location = 0;//My Location on the racetrack
        public Random Randmizer;//An instance of Random

        public bool Run()
        {
            //Move forward either 1,2,3 or 4 spaces at radom
            //Update the position of my PictuerBox on the form like this:
            //MyPictureBox.Left=StartingPosition+Location;
            //Return true if I won the race
            Location += Randmizer.Next(1,10);
            MyPictureBox.Left = StartingPosition+ Location;
            if (MyPictureBox.Left > RacetrackLength)
                return true;
            else
                return false;
        }
        public void TakeStartingPosition()
        {
            //Reset my location to 0 and my PictureBox to starting position
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
