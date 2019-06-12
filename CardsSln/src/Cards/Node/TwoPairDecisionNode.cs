using Cards.Hand;
using System.Linq;

namespace Cards.Node
{
    public class TwoPairDecisionNode : INode<IHand, PokerHandScore>
    {
        const int Score = 3;
        const string HandType = "Two Pair";

        public PokerHandScore Eval(IHand client)
        {
            var high = client.Cards.Max(c => c.Rank);
            var answer = new PokerHandScore(Score, (PokerHandScore.CardValue)high, HandType);
            return answer;
        }
    }
}