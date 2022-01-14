namespace StrategyPattern.Message
{
    public class MessageContext
    {
        private AbsMessageStrategy _absMessageStrategy;

        public MessageContext(AbsMessageStrategy absMessageStrategy)
        {
            _absMessageStrategy = absMessageStrategy;
        }

        public void SendMessage(User user, string data)
        {
            _absMessageStrategy.SendMessage(user, data);
        }
    }
}