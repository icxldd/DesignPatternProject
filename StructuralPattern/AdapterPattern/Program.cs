using System;
using AdapterPattern._91Porn;
using AdapterPattern.BaiDuCloud;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // AbsPhoneTest();
            // BaiduCloudTest();
            // PornTest();
            
            
            
        }

        private static void PornTest()
        {
            new Rank91PornAdapter(new PornAdaptee()).Watch(Guid.NewGuid());
            new Vip91PornAdapter(new PornAdaptee()).Watch(Guid.NewGuid());
        }

        private static void BaiduCloudTest()
        {
            new RankBaiDuAdapter().Download();
            new VipBaiDuAdapter().Download();
        }

        private static void AbsPhoneTest()
        {
            new XiaomiAdapter().Charger();
            new HuaWeiAdapter().Shutdown();
            new IosAdapter().StartUp();
        }
    }
}