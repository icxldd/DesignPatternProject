using System;

namespace DecoratorPattern.Core.Message
{
    public class QqSendMessageDecorator : AbsSendMessageDecorator
    {
        public override void Send(Guid userId, string msg)
        {
            base.Send(userId, msg);

            Console.WriteLine($"qq发送{userId},{msg}消息");
        }

        public QqSendMessageDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }
    }
}