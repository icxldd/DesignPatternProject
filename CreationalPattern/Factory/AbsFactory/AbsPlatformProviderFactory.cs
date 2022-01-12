namespace Factory.AbsFactory
{
    /// <summary>
    /// 平台工厂
    /// </summary>
    public abstract class AbsPlatformProviderFactory
    {
        public abstract IStatCalculate CreateStatCalculateProvider();

        public abstract IPushMessage CreatePushMessageProvider();
    }
}