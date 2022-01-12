using Factory.FactoryMethod;

namespace Factory.FactoryMethod
{
    public class EmailFactory : AbsFactory
    {
        public override IMessageProvider CreateMessageProvider()
        {
            return new EmailMessageProvider();
        }
    }
}