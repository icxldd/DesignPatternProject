using System;

namespace DecoratorPattern.Core.Message
{
    public class MysqlHardSendMessageDecorator : AbsSendMessageDecorator
    {
        public override void Send(Guid userId, string msg)
        {
            base.Send(userId, msg);

            Console.WriteLine($"mysql存入{userId},{msg}消息");
        }

        public MysqlHardSendMessageDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }
    }
}