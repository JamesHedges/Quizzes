using System;
using System.Collections.Generic;
using Xunit;
using Cards;
using FluentAssertions;

namespace CardsTests
{
    public class DeckTests
    {
        [Fact]
        public void Test1()
        {
            var deck = CreateDeck();
            var card = deck.Deal();
            card.Should().NotBeNull();
        }

       private static IDeck CreateDeck()
       {
            var cards = new List<ICard>();
            for (int s = 0; s < 4; s++)
            {
                cards.Add(new AceCard
                {
                    Suit = (Suit)s, 
                    Rank =14
                });
                for (int r = 1; r < 13; r++)
                {
                    cards.Add(new Card
                    {
                        Suit = (Suit)s, 
                        Rank = r 
                    } );
                }
            }

            return new Deck(cards);
       }
    }
}
