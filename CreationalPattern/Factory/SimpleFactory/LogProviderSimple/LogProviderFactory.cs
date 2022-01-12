namespace Factory.SimpleFactory.LogProviderSimple
{
    public static class LogProviderFactory
    {
        public static ILogProvider Create(LogProviderType logProviderType)
        {
            ILogProvider provider = null;
            switch (logProviderType)
            {
                case LogProviderType.Mysql:
                    provider = new MysqlLogProvider();
                    break;
                case LogProviderType.Local:
                    provider = new LocalLogProvider();
                    break;
                default:
                    break;
            }

            return provider;
        }
    }
}