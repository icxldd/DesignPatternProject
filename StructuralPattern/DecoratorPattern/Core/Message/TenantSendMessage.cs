using System;

namespace DecoratorPattern.Core.Message
{
    public class TenantSendMessage : ISendMessage
    {
        private Guid _tenantId;

        public TenantSendMessage(Guid tenantId)
        {
            _tenantId = tenantId;
        }

        public void Send(Guid userId, string msg)
        {
            Console.WriteLine($"向租户{_tenantId.ToString()}；用户{userId}；发送消息：{msg}");
        }
    }
}