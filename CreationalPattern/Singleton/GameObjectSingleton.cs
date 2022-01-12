using System;

namespace Singleton
{
    public class GameObjectSingleton<T> where T : class
    {
        private static T _singleton;

        private static readonly object _lock = new object();

        private GameObjectSingleton()
        {
        }

        public static T GetSingleton()
        {
            if (_singleton == null)
            {
                lock (_lock)
                {
                    if (_singleton == null)
                    {
                        _singleton = Activator.CreateInstance(typeof(T)) as T;
                    }
                }
            }

            return _singleton;
        }
    }
}