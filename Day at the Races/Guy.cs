using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_at_the_Races
{
    class Guy
    {
        public string Name;//The guy's name
        public Bet MyBet;//An instance of Bet that has his bet
        public int Cash;// How much cash he has
        // The last two fields are the Guy's GUI controls on the form
        public RadioButton MyRadionButton;//My RadioButton
        public Label MyLabel;// My Label

        public void UpdateLabels()
        {
            //Set my label to my bet's description,and the label on my
            //radio button to show my cash("Joe has 43 bucks")
            MyRadionButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = Name + " hasn't place a bet";
        }
        public void ClearBet()
        {
            // Reset my bet so it's zero
            MyBet.Amount = 0;
            MyBet.Dog = 0;
            MyBet.Bettor = null;
            MyBet = null;
        }
        public bool PlaceBet(int BetAmount,int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            if (BetAmount <= Cash)
            {
                MyBet = new Bet()
                {
                    Amount = BetAmount,
                    Dog = DogToWin,
                    Bettor = this
                };
                return true;
            }
            else
                return false;
        }
        public void Collect(int winner)
        {
            //Ask my bet to pay out,clear my bet,clear my bet,and update my labels
            Cash += MyBet.PayOut(winner);
            this.UpdateLabels();
            this.ClearBet();
        }
    }
}