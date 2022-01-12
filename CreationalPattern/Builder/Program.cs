using System;
using Builder.Core;
using Builder.Core.Factory;
using Builder.Core.Friend;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFactoryBuilder();
            // TestFriend();
        }

        private static void TestFriend()
        {
            FriendManager friendManager = new FriendManagerBuilder().AddFriendCompleteEvent(() =>
            {
                Console.WriteLine("监听加好友成功回调");
            }).Builder();
            friendManager.AddFriend(Guid.NewGuid());
        }

        private static void TestFactoryBuilder()
        {
            AbsPlatformManager platformManager = new H5PlatformManagerBuilder().AddMessageCompleteEvent((userId,
                message) =>
            {
                Console.WriteLine($"H5监听发送完毕：{userId},{message}");
            }).Builder();
            Guid userId = Guid.NewGuid();
            string message = "message";
            platformManager.SendUserMessage(userId, message);


            AbsPlatformManager appPlatformManager = new AppPlatformManagerBuilder().AddMessageCompleteEvent((userId,
                message) =>
            {
                Console.WriteLine($"App监听发送完毕：{userId},{message}");
            }).Builder();
            appPlatformManager.SendUserMessage(userId, message);


            AbsPlatformManager UsaAppPlatformManager = new USAAppPlatformManagerBuilder().AddMessageCompleteEvent((
                userId,
                message) =>
            {
                Console.WriteLine($"美国App监听发送完毕：{userId},{message}");
            }).Builder();
            UsaAppPlatformManager.SendUserMessage(userId, message);
        }
    }
}