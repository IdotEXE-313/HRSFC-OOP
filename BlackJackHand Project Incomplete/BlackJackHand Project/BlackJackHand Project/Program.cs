using System;
using CardClasses;

namespace BlackJackHand_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card(4, 3);
            var card1 = new Card(11, 3);
            var card2 = new Card(4, 3);
            var blackjack = new BlackJackHand();

            /*Outputs 22 because adds 11, then adds 10, then adds 1 because adding 11 would take the score over 21*/
            blackjack.AddCard(card);
            blackjack.AddCard(card1);
            blackjack.AddCard(card2);

            Console.WriteLine(blackjack.GetScore());
        }
    }
}
