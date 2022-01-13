using System;

namespace AdapterPattern._91Porn
{
    public class PornAdaptee
    {
        public void Watch(Guid videoId)
        {
            Console.WriteLine($"查看视频{videoId.ToString()}");
        }

        public void Download(Guid videoId)
        {
            Console.WriteLine($"下载视频{videoId.ToString()}");
        }
    }
}