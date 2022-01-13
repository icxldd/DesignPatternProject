using System.IO;
using System.Text;

namespace DecoratorPattern.Core
{
    public class FileDataSource : IDataSource
    {
        private readonly string _fileName;

        public FileDataSource(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteData(string data)
        {
            using var file = File.Open(_fileName, FileMode.OpenOrCreate);
            var bytes = Encoding.UTF8.GetBytes(data);
            file.Write(bytes, 0, bytes.Length);
        }

        public string ReadData()
        {
            return File.ReadAllTextAsync(_fileName).Result;
        }
    }
}