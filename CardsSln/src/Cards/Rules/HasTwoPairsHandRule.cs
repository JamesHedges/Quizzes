using System.Collections.Generic;
using System.Linq;

namespace Cards.Rules
{
    public class HasTwoPairsHandRule : ICardHandRule
    {
        public bool Eval(IHand hand)
        {
            List<ICard> cards = hand.Cards.ToList();
            var pairs = cards.GroupBy(c => c.Rank)
                .Select(cg => new {RankGroup = cg.Key, RankCount = cg.Count()})
                .Count(m => m.RankCount == 2)
                ;
            return pairs == 2;
        }
    }
}