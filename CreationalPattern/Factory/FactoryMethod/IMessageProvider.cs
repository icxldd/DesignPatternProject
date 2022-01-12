using System;

namespace Factory.FactoryMethod
{
    /// <summary>
    /// 发送用户消息
    /// </summary>
    public interface IMessageProvider
    {
        void SendMessage(Guid userId, string message);
    }
}