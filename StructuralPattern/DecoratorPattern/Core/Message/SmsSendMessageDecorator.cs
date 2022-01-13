using System;

namespace DecoratorPattern.Core.Message
{
    public class SmsSendMessageDecorator : AbsSendMessageDecorator
    {
        public override void Send(Guid userId, string msg)
        {
            base.Send(userId, msg);

            Console.WriteLine($"Sms发送{userId},{msg}消息");
        }

        public SmsSendMessageDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }
    }
}