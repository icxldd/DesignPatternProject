using System;
using Common;

namespace Factory.FactoryMethod
{
    public class FactoryMethodMessageProviderUnitTest : AbsUnitTest
    {
        public override void Test()
        {
            while (true)
            {
                Console.WriteLine("请输入1|2|3");
                int type = Convert.ToInt32(Console.ReadLine());
                Guid userId = Guid.NewGuid();
                string message = "你好";
                switch (type)
                {
                    case 1:
                        AbsFactory jiGuangFactory = new JiGuangFactory();
                        jiGuangFactory.CreateMessageProvider().SendMessage(userId, message);
                        break;
                    case 2:
                        AbsFactory smsFactory = new SmsFactory();
                        smsFactory.CreateMessageProvider().SendMessage(userId, message);
                        break;
                    case 3:
                        AbsFactory emailFactory = new EmailFactory();
                        emailFactory.CreateMessageProvider().SendMessage(userId, message);
                        break;
                }
            }
        }
    }
}