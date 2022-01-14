namespace ObserverPattern.Guild
{
    public abstract class AbsSubscriber<Subject> : IObserver<Subject>
    {
        public AbsSubscriber(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void ReceiveData(Subject subject, string data);
    }
}