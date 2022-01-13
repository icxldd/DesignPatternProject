namespace BridgePattern.Message
{
    public class H5UserManager : AbsUserManager
    {
        public H5UserManager(H5UserManagerProvider userManagerProvider) : base(userManagerProvider)
        {
        }
    }
}