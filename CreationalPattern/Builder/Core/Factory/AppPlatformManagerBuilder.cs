namespace Builder.Core
{
    public class AppPlatformManagerBuilder : AbsPlatformManagerBuilder
    {
        public override AbsPlatformManager Builder()
        {
            var appPlatformManager = new AppPlatformManager(this.MessageComplete);
            return appPlatformManager;
        }
    }
}