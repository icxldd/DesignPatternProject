using System;

namespace Factory.SimpleFactory.DBSimple
{
    public static class DbSimple
    {
        public static void MainTest()
        {
            while (true)
            {
                Console.WriteLine("请输入1|2|3");
                DbType inputType = Enum.Parse<DbType>(Console.ReadLine()!);

                var provider = DbProviderFactory.CreateDbProvider(inputType);
                
                provider.PrintDbClient();

            }
        }
    }

    public static class DbProviderFactory
    {
        public static IDbProvider CreateDbProvider(DbType dbType)
        {
            IDbProvider provider = null;
            switch (dbType)
            {
                case DbType.Mysql:
                    provider = new MysqlDbProvider();
                    break;
                case DbType.Pgsql:
                    provider = new PgsqlDbProvider();
                    break;
                case DbType.Sqlserver:
                    provider = new SqlserverDbProvider();
                    break;
                default:
                    break;
            }

            return provider;
        }
    }
}