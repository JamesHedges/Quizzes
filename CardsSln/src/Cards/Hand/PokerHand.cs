using System;
using System.Collections.Generic;

namespace Cards.Hand
{
    public class PokerHand : IHand
    {
        const int MaxCards = 5;
        private List<ICard> _cards;

        public PokerHand()
        {
            _cards = new List<ICard>();
        }

        public IEnumerable<ICard> Cards => _cards;

        public void Add(ICard card)
        {
            if (_cards.Count > MaxCards)
                throw new Exception("Max number of cards reached.");
            _cards.Add(card);
        }

        public void Remove(ICard card)
        {
            _cards.Remove(card);
        }
    }
}