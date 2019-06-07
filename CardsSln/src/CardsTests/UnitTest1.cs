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
            var cards = new List<ICard>()
            {
                new Card(){ Suit = Suit.Heart, Rank = 2 },
                new Card(){ Suit = Suit.Club, Rank = 4 }
            };
            var deck = new Deck(cards);
            var card = deck.Deal();
            card.Should().NotBeNull();
        }
    }
}
