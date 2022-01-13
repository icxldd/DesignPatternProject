using System;

namespace DecoratorPattern.Core.Message
{
    public interface ISendMessage
    {
        void Send(Guid userId, string msg);
    }
}