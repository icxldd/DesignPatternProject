using System;

namespace Factory.AbsFactory
{
    /// <summary>
    /// 给用户推送消息
    /// </summary>
    public interface IPushMessage
    {
        void PushMessage(Guid userId);
    }
}