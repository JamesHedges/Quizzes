using System;

namespace Cards
{
    public class AceCard : ICard
    {
        public AceCard()
        {
            AceHigh = true;
        }

        public Suit Suit { get; set; }
        public int Rank 
        { 
            get
            {
                return AceHigh ? 14 : 1;
            }
            set
            {
                if (value == 1)
                {
                    AceHigh = false;
                }
                else if (value == 14)
                {
                    AceHigh = true;
                }
                else 
                {
                    throw new ArgumentException("Invalid rank for an Ace card");
                }
            }
        }

        public bool AceHigh {get; set;}
    }

}