namespace ObserverPattern.Guild
{
    public interface IObserver<Subject>
    {
        void ReceiveData(Subject subject, string data);
    }
}