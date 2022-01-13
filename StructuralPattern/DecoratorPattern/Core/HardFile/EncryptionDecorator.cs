using System;
using System.Text;

namespace DecoratorPattern.Core
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        private string Encode(string data)
        {
            var bytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(bytes);
        }

        private string Decode(string data)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(data));
        }


        public override string ReadData()
        {
            var data = base.ReadData();
            string deCodeResult = Decode(data);
            return deCodeResult;
        }

        public override void WriteData(string data)
        {
            string enCode = Encode(data);
            base.WriteData(enCode);
        }
    }
}