using System.Collections.Generic;

namespace Cards
{
    public class DeckFactory
    {
        public static IDeck CreateStandardDeck()
        {
            var cards = new List<ICard>();
            for (int s = 0; s < 4; s++)
            {
                cards.Add(new AceCard
                {
                    Suit = (Suit)s, 
                    Rank =14
                });
                for (int r = 1; r < 13; r++)
                {
                    cards.Add(new Card
                    {
                        Suit = (Suit)s, 
                        Rank = r 
                    } );
                }
            }

            return new Deck(cards);
        }
    }
}