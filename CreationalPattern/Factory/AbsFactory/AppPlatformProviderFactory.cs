namespace Factory.AbsFactory
{
    /// <summary>
    /// app
    /// </summary>
    public class AppPlatformProviderFactory : AbsPlatformProviderFactory
    {
        public override IStatCalculate CreateStatCalculateProvider()
        {
            return new AppStatCalculate();
        }

        public override IPushMessage CreatePushMessageProvider()
        {
            return new AppPushMessage();
        }
    }
}