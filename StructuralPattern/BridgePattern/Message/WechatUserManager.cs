namespace BridgePattern.Message
{
    public class WechatUserManager : AbsUserManager
    {
        public WechatUserManager(WechatUserManagerProvider userManagerProvider) : base(userManagerProvider)
        {
        }
    }
}