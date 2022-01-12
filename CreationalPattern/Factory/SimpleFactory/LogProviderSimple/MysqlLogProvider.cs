using System;

namespace Factory.SimpleFactory.LogProviderSimple
{
    public class MysqlLogProvider : ILogProvider
    {
        public void WriteLog(string log)
        {
            Console.WriteLine($"往mysql 写入{log}");
        }
    }
}