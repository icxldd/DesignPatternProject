namespace StrategyPattern.Message
{
    public abstract class AbsMessageStrategy
    {
        public abstract void SendMessage(User user, string data);
    }
}