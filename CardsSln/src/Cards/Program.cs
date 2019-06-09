using System;
using System.Collections.Generic;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CheckDeck();

            
        }

        private static void CheckDeck()
        {

            var deck = DeckFactory.CreateStandardDeck();

            for(var i = 0; i < 52; i++)
                DrawCard(deck);
       }

       private static void DrawCard(IDeck deck)
       {
            var card = deck.Deal();
            Console.WriteLine($"Card is {card.Suit.ToString()} with rank {card.Rank}");
       }
    }
}
