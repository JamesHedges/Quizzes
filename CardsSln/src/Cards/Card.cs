using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cards
{
    public interface ICard
    {
        Suit Suit { get; set; }
        int Rank { get; set; }
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

    public class Card : ICard
    {
        public Card()
        {
        }

        public Card(Suit suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public Suit Suit { get; set; }
        public int Rank { get; set; }
    }
}