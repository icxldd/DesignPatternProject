namespace DecoratorPattern.Core
{
    public abstract class DataSourceDecorator : IDataSource
    {
        private readonly IDataSource _dataSource;

        public DataSourceDecorator(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public virtual void WriteData(string data)
        {
            _dataSource.WriteData(data);
        }

        public virtual string ReadData()
        {
            return _dataSource.ReadData();
        }
    }
}