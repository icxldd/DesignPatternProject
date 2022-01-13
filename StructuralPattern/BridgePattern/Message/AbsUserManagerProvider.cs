using System;

namespace BridgePattern.Message
{
    public abstract class AbsUserManagerProvider
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="msg"></param>
        public abstract void SendMessage(Guid userId, string msg);

        /// <summary>
        /// 强制下线
        /// </summary>
        /// <param name="userId"></param>
        public abstract void TapeOut(Guid userId);
    }
}