using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_at_the_Races
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public string GetDescription()
        {
            string description;
            if (Amount != 0)
                description = Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            else
                description = Bettor.Name + " has't placed a bet";
            return description;
        }
        public int PayOut(int winner)
        {
            if (Dog == winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
