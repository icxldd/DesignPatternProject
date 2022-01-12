using System;

namespace Builder.Core
{
    public abstract class AbsPlatformManagerBuilder
    {
        protected Action<Guid, string> MessageComplete { get; private set; }

        public AbsPlatformManagerBuilder AddMessageCompleteEvent(Action<Guid, string> messageComplete)
        {
            this.MessageComplete = messageComplete;
            return this;
        }


        public abstract AbsPlatformManager Builder();
    }
}