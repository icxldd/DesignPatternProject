using System;

namespace AdapterPattern.BaiDuCloud
{
    /// <summary>
    /// Vip用户
    /// </summary>
    public class VipBaiDuAdapter : BaiDuAdaptee, IBaiDuTarget
    {
        public void Download()
        {
            Console.WriteLine("您是VIP");
            base.Download(3000);
        }

        public void Upload()
        {
            Console.WriteLine("您是VIP");
            base.Upload(100000);
        }
    }
}