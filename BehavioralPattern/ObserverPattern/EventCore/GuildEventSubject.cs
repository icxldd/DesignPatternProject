using System;

namespace ObserverPattern.EventCore
{
    public class GuildEventSubject
    {
        public event Action<string> SendData;

        public void SendDataFunc(string data)
        {
            if (SendData != null) SendData(data);
        }
    }
}