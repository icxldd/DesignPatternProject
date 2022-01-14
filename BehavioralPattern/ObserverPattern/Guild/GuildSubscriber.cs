using System;

namespace ObserverPattern.Guild
{
    public class GuildSubscriber : AbsSubscriber<GuildSubject>
    {
        public GuildSubscriber(string name) : base(name)
        {
        }

        public override void ReceiveData(GuildSubject subject, string data)
        {
            Console.WriteLine($"{this.Name}收到{subject.GuildName}教会的消息：{data}");
        }
    }
}