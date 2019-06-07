using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards
{
    public interface IDeck
    {
        ICard Deal();
    }

    public class Deck : IDeck
    {
        private readonly List<ICard> _cards;
        private Random _random;

        public Deck(List<ICard> cards)
        {
            _cards = cards;
            _random = new Random();
        }
        public ICard Deal()
        {
            int next = _random.Next(0, _cards.Count() -1);
            var card = _cards[next];
            _cards.RemoveAt(next);
            return card;
        }
    }
}