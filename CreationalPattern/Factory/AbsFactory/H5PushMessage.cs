using System;

namespace Factory.AbsFactory
{
    public class H5PushMessage : IPushMessage
    {
        public void PushMessage(Guid userId)
        {
            Console.WriteLine("H5:发送消息完成" + userId.ToString());
        }
    }
}