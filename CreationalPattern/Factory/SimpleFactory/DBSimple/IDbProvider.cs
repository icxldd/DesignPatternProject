namespace Factory.SimpleFactory.DBSimple
{
    public interface IDbProvider
    {
        /// <summary>
        /// 获取db客户端
        /// </summary>
        /// <returns></returns>
        void PrintDbClient();
    }
}