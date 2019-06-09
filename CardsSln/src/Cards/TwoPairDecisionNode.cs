using System.Linq;

namespace Cards
{
    public class TwoPairDecisionNode : INode<IHand, PokerHandScore>
    {
        const int Score = 2;
        const string HandType = "Pair";

        public PokerHandScore Eval(IHand client)
        {
            var high = client.Cards.Max(c => c.Rank);
            var answer = new PokerHandScore(Score, (PokerHandScore.CardValue)high, HandType);
            return answer;
        }
    }
}