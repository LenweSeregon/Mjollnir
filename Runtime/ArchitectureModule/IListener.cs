namespace Fafnir.Mjollnir.Architecture
{
    public interface IListener<T>
    {
        void Raise(T value);
    }
}