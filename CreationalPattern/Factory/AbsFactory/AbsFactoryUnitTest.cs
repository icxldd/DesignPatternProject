using System;
using Common;

namespace Factory.AbsFactory
{
    public class AbsFactoryUnitTest : AbsUnitTest
    {
        public override void Test()
        {
            while (true)
            {
                Console.WriteLine("请输入1|2");
                int type = Convert.ToInt32(Console.ReadLine());
                Guid userId = Guid.NewGuid();
                string message = "你好";
                switch (type)
                {
                    case 1:
                        AbsPlatformProviderFactory h5PlatformProviderFactory = new H5PlatformProviderFactory();
                        h5PlatformProviderFactory.CreatePushMessageProvider().PushMessage(userId);
                        h5PlatformProviderFactory.CreateStatCalculateProvider().CalcTodayData();
                        break;
                    case 2:
                        AbsPlatformProviderFactory appPlatformProviderFactory = new AppPlatformProviderFactory();
                        appPlatformProviderFactory.CreatePushMessageProvider().PushMessage(userId);
                        appPlatformProviderFactory.CreateStatCalculateProvider().CalcTodayData();
                        break;
                }
            }
        }
    }
}