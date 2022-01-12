namespace Builder.Core
{
    public class H5PlatformManagerBuilder : AbsPlatformManagerBuilder
    {
        public override AbsPlatformManager Builder()
        {
            var h5PlatformManager = new H5PlatformManager(this.MessageComplete);
            return h5PlatformManager;
        }
    }
}