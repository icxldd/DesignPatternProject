namespace Builder.Core.Factory
{
    public class USAH5PlatformManagerBuilder : H5PlatformManagerBuilder
    {
        public override AbsPlatformManager Builder()
        {
            var appPlatformManager = new USAH5PlatformManager(this.MessageComplete);
            return appPlatformManager;
        }
    }
}