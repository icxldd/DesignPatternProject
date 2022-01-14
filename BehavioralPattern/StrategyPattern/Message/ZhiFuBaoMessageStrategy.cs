using System;

namespace StrategyPattern.Message
{
    public class ZhiFuBaoMessageStrategy : AbsMessageStrategy
    {
        public override void SendMessage(User user, string data)
        {
            Console.WriteLine($"从支付宝给{user.Name}发送消息：{data}");
        }
    }
}