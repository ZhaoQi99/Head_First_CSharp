using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_at_the_Races
{
    class Bet
    {
        public int Amount;//The amount of cash that was bet
        public int Dog;// The number of the dog the bet is on
        public Guy Bettor;//The guy who placed the bet
        public string GetDescription()
        {
            //Return a string that says who placed the bet,how much
            //cash was bet,and which dog he bet on("Joe bets 8 on
            //dog #4").If the amount is zero,no bet was placed\
            //("joe　hasn't placed a bet").
            string description;
            if (Amount != 0)
                description = Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            else
                description = Bettor.Name + " has't placed a bet";
            return description;
        }
        public int PayOut(int winner)
        {
            //The paameter is the winner of the race.If the dog won,
            //return the amount bet.Otherwise,return the negative of
            //the amount bet.
            if (Dog == winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
