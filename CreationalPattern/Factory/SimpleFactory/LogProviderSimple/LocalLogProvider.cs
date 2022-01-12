using System;

namespace Factory.SimpleFactory.LogProviderSimple
{
    public class LocalLogProvider : ILogProvider
    {
        public void WriteLog(string log)
        {
            Console.WriteLine($"往本地文件写入{log}");
        }
    }
}