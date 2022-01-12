using System;

namespace Factory.SimpleFactory.DBSimple
{
    public class PgsqlDbProvider : IDbProvider
    {
        public void PrintDbClient()
        {
            Console.WriteLine("我是Pgsql 提供者");
        }
    }
}