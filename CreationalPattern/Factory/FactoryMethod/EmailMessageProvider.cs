using System;

namespace Factory.FactoryMethod
{
    public class EmailMessageProvider : IMessageProvider
    {
        public void SendMessage(Guid userId, string message)
        {
            Console.WriteLine($"邮件发送: {userId.ToString()} : {message}");
        }
    }
}