namespace Cards.Node
{
    public interface INode<T, R>
    {
        R Eval(T client);
    }
}