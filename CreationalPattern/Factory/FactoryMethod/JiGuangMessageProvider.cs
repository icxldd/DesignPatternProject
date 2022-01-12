using System;

namespace Factory.FactoryMethod
{
    public class JiGuangMessageProvider : IMessageProvider
    {
        public void SendMessage(Guid userId, string message)
        {
            Console.WriteLine($"极光发送：{userId.ToString()}:{message}");
        }
    }
}