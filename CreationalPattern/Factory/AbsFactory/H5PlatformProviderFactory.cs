namespace Factory.AbsFactory
{
    /// <summary>
    /// h5网页
    /// </summary>
    public class H5PlatformProviderFactory : AbsPlatformProviderFactory
    {
        public override IStatCalculate CreateStatCalculateProvider()
        {
            return new H5StatCalculate();
        }

        public override IPushMessage CreatePushMessageProvider()
        {
            return new H5PushMessage();
        }
    }
}