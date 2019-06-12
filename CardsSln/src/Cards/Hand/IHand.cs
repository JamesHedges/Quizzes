using System.Collections.Generic;

namespace Cards.Hand
{
    public interface IHand
    {
        IEnumerable<ICard> Cards { get; }
        void Add(ICard card);
        void Remove(ICard card);
    }
}