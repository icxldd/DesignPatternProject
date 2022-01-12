using System;

namespace Builder.Core.Friend
{
    public class FriendManagerBuilder
    {
        private Action _addFriendComplete;

        public FriendManagerBuilder AddFriendCompleteEvent(Action action)
        {
            _addFriendComplete = action;
            return this;
        }

        public FriendManager Builder()
        {
            return new FriendManager(_addFriendComplete);
        }
    }
}