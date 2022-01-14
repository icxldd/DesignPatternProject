namespace StrategyPattern.Money
{
    public class NormalCash : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}