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
            int score = 10;
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
                    score = (score + 11 <= 21) ? score += 11 : score+= 1; //If an ace is drawn and adding 11 doesn't exceed 21, then we add 11. If it does exceed 21, we add 1 to the score.
                }

            }
            return score;
        }
    }
}
