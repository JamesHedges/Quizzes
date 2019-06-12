using Cards.Hand;

namespace Cards.Rules
{
    public interface ICardHandRule
    {
         bool Eval(IHand hand);
    }
}