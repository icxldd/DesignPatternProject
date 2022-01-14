using System.Collections.Generic;

namespace ObserverPattern.Guild
{
    public class GuildSubject
    {
        private List<AbsSubscriber<GuildSubject>> _subscribers;

        public GuildSubject(string guildName)
        {
            GuildName = guildName;
            _subscribers = new List<AbsSubscriber<GuildSubject>>();
        }

        public void AddObserver(AbsSubscriber<GuildSubject> obj)
        {
            _subscribers.Add(obj);
        }

        public void RemoveObserver(AbsSubscriber<GuildSubject> obj)
        {
            _subscribers.Remove(obj);
        }

        public void SendData(string data)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.ReceiveData(this, data);
            }
        }


        public string GuildName { get; }
    }
}