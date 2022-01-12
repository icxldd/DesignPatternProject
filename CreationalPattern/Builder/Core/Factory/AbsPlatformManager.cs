using System;

namespace Builder.Core
{
    public abstract class AbsPlatformManager
    {
        /// <summary>
        /// 消息发送完成回调
        /// </summary>
        private Action<Guid, string> _messageComplete;

        protected AbsPlatformManager(Action<Guid, string> messageComplete)
        {
            _messageComplete = messageComplete;
        }

        protected AbsPlatformManager()
        {
        }

        public virtual void SendUserMessage(Guid userId, string msg)
        {
            if (_messageComplete != null)
            {
                _messageComplete(userId, msg);
            }
        }
    }
}