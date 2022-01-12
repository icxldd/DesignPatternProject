using System;

namespace Factory.FactoryMethod
{
    public class SmsMessageProvider : IMessageProvider
    {
        public void SendMessage(Guid userId, string message)
        {
            Console.WriteLine($"短信发送: {userId.ToString()} : {message}");
        }
    }
}