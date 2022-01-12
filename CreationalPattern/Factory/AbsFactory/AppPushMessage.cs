using System;

namespace Factory.AbsFactory
{
    public class AppPushMessage : IPushMessage
    {
        public void PushMessage(Guid userId)
        {
            Console.WriteLine("App:发送消息完成" + userId.ToString());
        }
    }
}