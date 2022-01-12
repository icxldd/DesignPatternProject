namespace Builder.Core.Factory
{
    public class USAAppPlatformManagerBuilder : AppPlatformManagerBuilder
    {
        public override AbsPlatformManager Builder()
        {
            var appPlatformManager = new USAAppPlatformManager(this.MessageComplete);
            return appPlatformManager;
        }
    }
}