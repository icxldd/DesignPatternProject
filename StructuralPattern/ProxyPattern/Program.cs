using System;
using ProxyPattern.Request;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpRequestProxy = new HttpRequestProxy();
            httpRequestProxy.Post();
        }
    }
}