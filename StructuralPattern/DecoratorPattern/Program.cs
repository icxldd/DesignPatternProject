using System;
using DecoratorPattern.Core;
using DecoratorPattern.Core.Message;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // HardFileTest();
            MessageTest();
        }

        private static void MessageTest()
        {
            Guid userId = Guid.NewGuid();
            string msg = "123123";
            var tenant = new TenantSendMessage(Guid.NewGuid());
            var mysql = new MysqlHardSendMessageDecorator(tenant);
            var qq = new QqSendMessageDecorator(mysql);
            var wechat = new WechatSendMessageDecorator(qq);
            var sms = new SmsSendMessageDecorator(wechat);

            sms.Send(userId, msg);
        }

        private static void HardFileTest()
        {
            var file = new FileDataSource("1.txt");
            var encode = new EncryptionDecorator(file);
            var compress = new CompressionDecorator(encode);
            compress.WriteData("123123123");
            Console.WriteLine(compress.ReadData());
        }
    }
}