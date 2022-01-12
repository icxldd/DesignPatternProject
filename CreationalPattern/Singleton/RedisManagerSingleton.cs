namespace Singleton
{
    public class RedisManagerSingleton
    {
        private static RedisManagerSingleton _redisManagerSingleton;

        private static readonly object _lock = new object();

        private RedisManagerSingleton()
        {
        }


        public static RedisManagerSingleton GetSingleton()
        {
            if (_redisManagerSingleton == null)
            {
                lock (_lock)
                {
                    if (_redisManagerSingleton == null)
                    {
                        _redisManagerSingleton = new RedisManagerSingleton();
                    }
                }
            }

            return _redisManagerSingleton;
        }
    }
}