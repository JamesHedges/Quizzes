namespace Cards
{
    public interface INode<T>
    {
        bool Eval(T client);
    }
}