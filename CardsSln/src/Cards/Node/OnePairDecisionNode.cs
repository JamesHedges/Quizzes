using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cards.Hand;

namespace Cards.Node
{
    class OnePairDecisionNode
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
