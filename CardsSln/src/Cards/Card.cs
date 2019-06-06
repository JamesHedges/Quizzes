using System.Runtime.Serialization;

namespace Cards
{
    public class Card
    {
        public Card()
        {
            
        }

        public enum Suit
        {
            [EnumMember(Value = "Spade")]
            Spade,
            [EnumMember(Value = "Club")]
            Club,
            [EnumMember(Value = "Diamond")]
            Diamond,
            [EnumMember(Value="Heart")]
            Heart
        }

        public Suit Suit { get; set; }
        public int Rank { get; set; }
    }

    public class AceCard : Card
    {
        public Ace()
        {
            AceHigh = true;
        }

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