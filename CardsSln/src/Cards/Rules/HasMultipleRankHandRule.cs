using Cards.Hand;
using System.Collections.Generic;
using System.Linq;

namespace Cards.Rules
{
    public class HasMultipleRankHandRule : ICardHandRule
    {
        public bool Eval(IHand hand)
        {
            List<ICard> cards = hand.Cards.ToList();
            return cards.GroupBy(c => c.Rank)
                .Any(cg => cg.Count() > 1)
                ;
        }
    }
}