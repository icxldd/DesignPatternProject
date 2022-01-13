using System;

namespace AdapterPattern._91Porn
{
    public class Vip91PornAdapter : I91PornTarget
    {
        protected PornAdaptee PornAdaptee { get; }

        public Vip91PornAdapter(PornAdaptee pornAdaptee)
        {
            PornAdaptee = pornAdaptee;
        }

        public void Watch(Guid videoId)
        {
            {
                PornAdaptee.Watch(videoId);
            }
        }

        public void Download(Guid videoId)
        {
            {
                PornAdaptee.Watch(videoId);
            }
        }
    }
}