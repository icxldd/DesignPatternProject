namespace BridgePattern.Message
{
    public class AppUserManager : AbsUserManager
    {
        public AppUserManager(AppUserManagerProvider userManagerProvider) : base(userManagerProvider)
        {
        }
    }
}