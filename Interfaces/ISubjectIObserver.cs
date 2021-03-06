namespace AromasEstoque
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(IObserver observer); 
        void Detach(IObserver observer);
        void Notify();
    }
}