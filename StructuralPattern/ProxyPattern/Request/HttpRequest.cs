using System;

namespace ProxyPattern.Request
{
    public class HttpRequest
    {
        public void Post()
        {
            Console.WriteLine("发送Post请求");
        }
    }

    public class HttpRequestProxy
    {
        private readonly HttpRequest _httpRequest;

        public HttpRequestProxy()
        {
            _httpRequest = new HttpRequest();
        }

        public void Post()
        {
            Console.WriteLine("HttpRequestProxy代理拦截，准备执行");
            _httpRequest.Post();
            Console.WriteLine("HttpRequestProxy代理拦截，执行完成");
        }

    }
}