using System;

namespace BridgePattern.Message
{
    public abstract class AbsUserManager
    {
        protected AbsUserManager(AbsUserManagerProvider userManagerProvider)
        {
            UserManagerProvider = userManagerProvider;
        }

        protected AbsUserManagerProvider UserManagerProvider { get; }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="msg"></param>
        public void SendMessage(Guid userId, string msg)
        {
            UserManagerProvider.SendMessage(userId, msg);
        }

        /// <summary>
        /// 强制下线
        /// </summary>
        /// <param name="userId"></param>
        public void TapeOut(Guid userId)
        {
            UserManagerProvider.TapeOut(userId);
        }
    }
}