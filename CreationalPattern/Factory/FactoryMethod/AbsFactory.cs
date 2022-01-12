namespace Factory.FactoryMethod
{
    public abstract class AbsFactory
    {
        public abstract IMessageProvider CreateMessageProvider();
    }
}