using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Cards;
using Cards.Rules;
using Cards.Hand;

namespace CardsTests
{
    public class HasMultipleRankHandRuleTests
    {
        [Fact]
        public void Hand_WithPair_EvalTrue()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new HasMultipleRankHandRule();

            var result = rule.Eval(hand);

            result.Should().BeTrue();
        }

        [Fact]
        public void Hand_With3OrKind_EvalTrue()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 2));

            ICardHandRule rule = new HasMultipleRankHandRule();

            var result = rule.Eval(hand);

            result.Should().BeTrue();
        }

        [Fact]
        public void Hand_WithNoPairs_EvalFalse()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 8));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new HasMultipleRankHandRule();

            var result = rule.Eval(hand);

            result.Should().BeFalse();
        }
    }
}