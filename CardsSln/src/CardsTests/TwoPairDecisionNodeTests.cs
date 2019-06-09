using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Cards;

namespace CardsTests
{
    public class TwoPairDecisionNodeTests
    {
        [Fact]
        public void TwoPairDecision_HandType_ReturnsPair()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            var sut = new TwoPairDecisionNode();

            var result = sut.Eval(hand);

            result.HandType.Should().Be("Pair");
        }

        [Fact]
        public void TwoPairDecision_HighCard_ReturnsPair()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            var sut = new TwoPairDecisionNode();

            var result = sut.Eval(hand);

            result.HighCard.Should().Be(5);
        }

        [Fact]
        public void TwoPairDecision_Score_ReturnsPair()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            var sut = new TwoPairDecisionNode();

            var result = sut.Eval(hand);

            result.Score.Should().Be(2);
        }
    }
}