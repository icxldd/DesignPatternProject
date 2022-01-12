using Factory.FactoryMethod;

namespace Factory.FactoryMethod
{
    public class SmsFactory : AbsFactory
    {
        public override IMessageProvider CreateMessageProvider()
        {
            return new SmsMessageProvider();
        }
    }
}