namespace Singleton
{
    public class GlobalDataSingleton
    {
        /// <summary>
        /// 定义为static，可以保证变量为线程安全的，即每个线程一个实例
        /// </summary>
        private static GlobalDataSingleton globalDataSingleton = new GlobalDataSingleton();

        private GlobalDataSingleton()
        {
        }


        public static GlobalDataSingleton GetSingleton() => globalDataSingleton;
    }
}