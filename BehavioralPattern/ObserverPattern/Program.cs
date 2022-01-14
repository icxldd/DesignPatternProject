using System;
using ObserverPattern.EventCore;
using ObserverPattern.Guild;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SubjectTest();
            // EventTest();
        }

        private static void EventTest()
        {
            var guildEventSubject = new GuildEventSubject();

            guildEventSubject.SendData += (data) => { Console.WriteLine("1" + data); };

            guildEventSubject.SendData += (data) => { Console.WriteLine("2" + data); };

            guildEventSubject.SendDataFunc("牛逼");
        }

        private static void SubjectTest()
        {
            var guildSubject = new GuildSubject("牛逼教会");

            guildSubject.AddObserver(new GuildSubscriber("信徒1"));
            guildSubject.AddObserver(new GuildSubscriber("信徒2"));
            guildSubject.AddObserver(new GuildSubscriber("信徒3"));

            guildSubject.SendData("牛逼起来啦");
        }
    }
}