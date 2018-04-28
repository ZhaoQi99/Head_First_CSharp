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
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadionButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadionButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = Name + " hasn't place a bet";
        }
        public void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
            MyBet.Bettor = null;
            MyBet = null;
        }
        public bool PlaceBet(int BetAmount,int DogToWin)
        {
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
            Cash += MyBet.PayOut(winner);
            this.UpdateLabels();
        }
    }
}
