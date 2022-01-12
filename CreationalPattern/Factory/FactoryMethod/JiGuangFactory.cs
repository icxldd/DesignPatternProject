using Factory.FactoryMethod;

namespace Factory.FactoryMethod
{
    public class JiGuangFactory : AbsFactory
    {
        public override IMessageProvider CreateMessageProvider()
        {
            return new JiGuangMessageProvider();
        }
    }
}