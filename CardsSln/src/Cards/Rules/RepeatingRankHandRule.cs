using System.Collections.Generic;
using System.Linq;

namespace Cards.Rules
{
    public class RepeatingRankHandRule : ICardHandRule
    {
        private readonly int _repeatCount;
        public RepeatingRankHandRule(int repeatCount)
        {
            _repeatCount = repeatCount;
        }

        public bool Eval(IHand hand)
        {
            List<ICard> cards = hand.Cards.ToList();
            return cards.GroupBy(c => c.Rank)
                .Any(cg => cg.Count() == _repeatCount)
                ;
        }
    }
}