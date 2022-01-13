using System.Security.Cryptography;

namespace DecoratorPattern.Core
{
    public interface IDataSource
    {
        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        void WriteData(string data);


        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string ReadData();
    }
}