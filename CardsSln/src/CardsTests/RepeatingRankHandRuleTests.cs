using Xunit;
using FluentAssertions;
using Cards;
using Cards.Rules;
using Cards.Hand;

namespace CardsTests
{
    public class RepeatingRankHandRuleTests
    {
        [Fact]
        public void Pair_WithPair_EvalTrue()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new RepeatingRankHandRule(2);

            var result = rule.Eval(hand);

            result.Should().BeTrue();
        }

        [Fact]
        public void Pair_WithPairAndThreeOfKind_EvalTrue()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 3));
            hand.Add(new Card(Suit.Spade, 3));

            ICardHandRule rule = new RepeatingRankHandRule(2);

            var result = rule.Eval(hand);

            result.Should().BeTrue();
        }

        [Fact]
        public void Pair_WithNoPair_EvalFalse()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 6));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new RepeatingRankHandRule(2);

            var result = rule.Eval(hand);

            result.Should().BeFalse();
        }

        [Fact]
        public void ThreeOfKind_WithThreeSameRank_EvalTrue()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 2));

            ICardHandRule rule = new RepeatingRankHandRule(3);

            var result = rule.Eval(hand);

            result.Should().BeTrue();
        }

        [Fact]
        public void ThreeOfKind_WithPair_EvalFalse()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new RepeatingRankHandRule(3);

            var result = rule.Eval(hand);

            result.Should().BeFalse();
        }

        [Fact]
        public void FourOfKind_WithFourSameRank_EvalTrue()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 2));
            hand.Add(new Card(Suit.Spade, 2));

            ICardHandRule rule = new RepeatingRankHandRule(4);

            var result = rule.Eval(hand);

            result.Should().BeTrue();
        }

        [Fact]
        public void FourOfKind_WithPair_EvalFalse()
        {
            IHand hand = new PokerHand();
            hand.Add(new Card(Suit.Heart, 2));
            hand.Add(new Card(Suit.Diamond, 2));
            hand.Add(new Card(Suit.Spade, 3));
            hand.Add(new Card(Suit.Club, 4));
            hand.Add(new Card(Suit.Spade, 5));

            ICardHandRule rule = new RepeatingRankHandRule(4);

            var result = rule.Eval(hand);

            result.Should().BeFalse();
        }
    }
}