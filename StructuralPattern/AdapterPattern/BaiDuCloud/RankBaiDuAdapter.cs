using System;

namespace AdapterPattern.BaiDuCloud
{
    /// <summary>
    /// 普通用户
    /// </summary>
    public class RankBaiDuAdapter : BaiDuAdaptee, IBaiDuTarget
    {
        public void Download()
        {
            Console.WriteLine("你是普通用户");
            base.Download(30);
        }

        public void Upload()
        {
            Console.WriteLine("你是普通用户");
            base.Upload(100);
        }
    }
}