using System.Collections.Generic;
using System.Linq;

namespace Cards.Rules
{
    public class MultipleRankHandRule : ICardHandRule
    {
        public bool Eval(IHand hand)
        {
            List<ICard> cards = hand.Cards.ToList();
            return cards.GroupBy(c => c.Rank)
                //.Select(cg => new {RankGroup = cg.Key, RankCount = cg.Count()})
                //.Any(m => m.RankCount > 1)
                .Any(cg => cg.Count() > 1)
                ;
        }
    }
}