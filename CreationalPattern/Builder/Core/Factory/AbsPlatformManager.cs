using System;

namespace Builder.Core
{
    public abstract class AbsPlatformManager
    {
        /// <summary>
        /// 消息发送完成回调
        /// </summary>
        protected Action<Guid, string> MessageComplete { get; }

        protected AbsPlatformManager(Action<Guid, string> messageComplete)
        {
            MessageComplete = messageComplete;
        }

        protected AbsPlatformManager()
        {
        }

        public virtual void SendUserMessage(Guid userId, string msg)
        {
            if (MessageComplete != null)
            {
                MessageComplete(userId, msg);
            }
        }
    }
}