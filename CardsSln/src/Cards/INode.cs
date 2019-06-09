namespace Cards
{
    public interface INode<T, R>
    {
        R Eval(T client);
    }
}