using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    internal class BlackJackHand : Hand
    {
        public int GetScore()
        {
            int score = 0;
            int numberOfAces = 0;
            foreach (var card in cards)
            {
                int currentRank = card.GetRank();
                
                if (currentRank >=2 && currentRank <= 10)
                {
                    score += currentRank; //Adds the face value of the rank to the score between 2 and 10
                }
                else if(currentRank > 10)
                {
                    score += 10; //Jack, Queen and King have a value of 10
                }
                else if(currentRank == 1)
                {
                    score += 11; //Add 11 as default for Ace
                    numberOfAces += 1;
                }

            }

            while(numberOfAces > 0 && score > 21)
            {
                score -= 10; // Count ace as one if the score goes over 10
                numberOfAces--;
            }
            return score;
        }
    }
}
