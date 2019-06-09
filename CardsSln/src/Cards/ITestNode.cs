using System;

namespace Cards
{
    public interface ITestNode<T> : INode<T>
    {
        T Positive { get; }
        T Negative { get; }
        Func<T, bool> Test { get; }
    }
}