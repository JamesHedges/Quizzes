using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Cards;
using Cards.Rules;
using Cards.Hand;

namespace CardsTests
{
    public class HasTwoPairsHandRuleTests
    {
        [Fact]
        public void TwoPairs_WithTwoPair_EvalTrue()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 3));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new HasTwoPairsHandRule();

            var result = rule.Eval(hand);

            result.Should().BeTrue();
        }

        [Fact]
        public void TwoPairs_WithOnePair_EvalFalse()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new HasTwoPairsHandRule();

            var result = rule.Eval(hand);

            result.Should().BeFalse();
        }

        [Fact]
        public void TwoPairs_WithNoPair_EvalFalse()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 6));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new HasTwoPairsHandRule();

            var result = rule.Eval(hand);

            result.Should().BeFalse();
        }

        [Fact]
        public void TwoPairs_WithPariAnd3OfKind_EvalFalse()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 3));
            hand.Add(new Card(Suit.Spade, 3));

            ICardHandRule rule = new HasTwoPairsHandRule();

            var result = rule.Eval(hand);

            result.Should().BeFalse();
        }

        [Fact]
        public void TwoPairs_WithPariAnd4OfKind_EvalFalse()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 3));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 3));
            hand.Add(new Card(Suit.Spade, 3));

            ICardHandRule rule = new HasTwoPairsHandRule();

            var result = rule.Eval(hand);

            result.Should().BeFalse();
        }
    }
}