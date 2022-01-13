namespace DecoratorPattern.Core
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            var data = base.ReadData();
            string deCodeResult = CompressHelper.DecompressString(data);
            return deCodeResult;
        }

        public override void WriteData(string data)
        {
            string enCode = CompressHelper.CompressString(data);
            base.WriteData(enCode);
        }
    }
}