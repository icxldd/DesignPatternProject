using System;

namespace Factory.SimpleFactory.DBSimple
{
    public class MysqlDbProvider : IDbProvider
    {
        public void PrintDbClient()
        {
            Console.WriteLine("我是mysql 提供者");
        }
    }
}