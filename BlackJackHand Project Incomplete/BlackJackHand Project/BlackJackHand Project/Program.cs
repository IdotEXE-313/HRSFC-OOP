using System;
using CardClasses;

namespace BlackJackHand_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new Card(1, 3);
            var blackjack = new BlackJackHand();

            blackjack.AddCard(card);
            Console.WriteLine(blackjack.GetScore()); 
        }
    }
}
