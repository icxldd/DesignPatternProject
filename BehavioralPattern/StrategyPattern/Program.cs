using System;
using StrategyPattern.Message;
using StrategyPattern.Money;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // MessageTest();


            var normal = new MoneyContext(new NormalCash());
            Console.WriteLine($"正常：{normal.GetMoney(50)}");

            var rebate = new MoneyContext(new CashRebate(0.5));
            Console.WriteLine($"打折：{rebate.GetMoney(50)}");

            var return_ = new MoneyContext(new CashReturn(20, 10));
            Console.WriteLine($"返利：{return_.GetMoney(50)}");


            Console.WriteLine("Hello World!");
        }

        private static void MessageTest()
        {
            var messageContext = new MessageContext(new ZhiFuBaoMessageStrategy());
            messageContext.SendMessage(new User("icxl", "127824533922@qq.com"), "6666");
        }
    }
}