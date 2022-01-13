using System;
using BridgePattern.Message;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid userId = Guid.NewGuid();
            string msg = "123123";

            new H5UserManager(new H5UserManagerProvider()).SendMessage(userId, msg);
            new AppUserManager(new AppUserManagerProvider()).SendMessage(userId, msg);
            new WechatUserManager(new WechatUserManagerProvider()).SendMessage(userId, msg);
            
            
            new H5UserManager(new H5UserManagerProvider()).TapeOut(userId);
            new AppUserManager(new AppUserManagerProvider()).TapeOut(userId);
            new WechatUserManager(new WechatUserManagerProvider()).TapeOut(userId);
        }
    }
}