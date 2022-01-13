using System;

namespace AdapterPattern._91Porn
{
    public class Rank91PornAdapter : I91PornTarget
    {
        protected PornAdaptee PornAdaptee { get; }

        public Rank91PornAdapter(PornAdaptee pornAdaptee)
        {
            PornAdaptee = pornAdaptee;
        }

        public void Watch(Guid videoId)
        {
            var d = new Random(2).Next(2);
            if (d < 2)
            {
                Console.WriteLine("你是普通用户，看不了");
            }
            else
            {
                PornAdaptee.Watch(videoId);
            }
        }

        public void Download(Guid videoId)
        {
            var d = new Random(2).Next(2);
            if (d < 2)
            {
                Console.WriteLine("你是普通用户，下载不了");
            }
            else
            {
                PornAdaptee.Watch(videoId);
            }
        }
    }
}