namespace Cards.Hand
{
    public class PokerHandScore
    {
        public PokerHandScore(int score, CardValue highCard, string handType)
        {
            Score = score;
            HighCard = highCard;
            HandType = handType;
        }

        public int Score { get; }
        public CardValue HighCard { get; }
        public string HandType { get; }

        public override string ToString()
        {
            return $"{HandType} with {HighCard.ToString()}";
        }

        public enum CardValue
        {
            AceLow = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            AceHigh
        }
    }
}