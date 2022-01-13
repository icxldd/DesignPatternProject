using System;

namespace DecoratorPattern.Core.Message
{
    public class WechatSendMessageDecorator : AbsSendMessageDecorator
    {
        public override void Send(Guid userId, string msg)
        {
            base.Send(userId, msg);

            Console.WriteLine($"wechat发送{userId},{msg}消息");
        }

        public WechatSendMessageDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
        }
    }
}