using System;

namespace Cards.Node
{
    public interface ITestNode<T, R> : INode<T, R>
    {
        T Positive { get; }
        T Negative { get; }
        Func<T, bool> Test { get; }
    }
}