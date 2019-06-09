namespace Cards
{
    public interface IDecisionNode<T> : INode<T>
    {
        string Answer { get; }
    }
}