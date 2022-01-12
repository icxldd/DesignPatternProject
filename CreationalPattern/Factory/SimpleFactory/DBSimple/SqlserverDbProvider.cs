using System;

namespace Factory.SimpleFactory.DBSimple
{
    public class SqlserverDbProvider : IDbProvider
    {
        public void PrintDbClient()
        {
            Console.WriteLine("我是Sqlserver 提供者");
        }
    }
}