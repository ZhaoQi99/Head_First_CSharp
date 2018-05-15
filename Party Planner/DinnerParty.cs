using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class DinnerParty
    {
        private const int CostOfFoodPersonb = 25;
        private int NumberOfPeople=5;
        private decimal CostOfBeveragesPerson;
        private decimal CostOfDecorations = 0;
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerson + CostOfFoodPersonb) * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
        public void SetPartyOption(int people,bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }
        public int getNumberOfPeoiple()
        {
            return NumberOfPeople;
        }
    }
}
