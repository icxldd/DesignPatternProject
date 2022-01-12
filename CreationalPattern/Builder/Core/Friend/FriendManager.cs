using System;

namespace Builder.Core.Friend
{
    public class FriendManager
    {
        private Action _addFriendComplete;

        public FriendManager()
        {
        }

        public FriendManager(Action addFriendComplete)
        {
            _addFriendComplete = addFriendComplete;
        }

        public void AddFriend(Guid userId)
        {
            Console.WriteLine($"添加userId{userId}成功");

            if (_addFriendComplete != null)
            {
                _addFriendComplete();
            }
        }
    }
}