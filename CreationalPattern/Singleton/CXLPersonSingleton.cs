namespace Singleton
{
    public class CXLPersonSingleton
    {
        private static CXLPersonSingleton _singleton;

        private CXLPersonSingleton()
        {
        }

        public static CXLPersonSingleton GetSingleton()
        {
            return _singleton ?? new CXLPersonSingleton();
        }
    }
}