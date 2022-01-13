using System;

namespace DecoratorPattern.Core.Message
{
    public abstract class AbsSendMessageDecorator : ISendMessage
    {
        private readonly ISendMessage _sendMessage;

        public AbsSendMessageDecorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public virtual void Send(Guid userId, string msg)
        {
            _sendMessage.Send(userId, msg);
        }
    }
}