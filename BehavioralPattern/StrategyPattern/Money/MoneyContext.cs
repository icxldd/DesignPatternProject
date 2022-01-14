namespace StrategyPattern.Money
{
    public class MoneyContext
    {
        private CashSuper _cashSuper;

        public MoneyContext(CashSuper cashSuper)
        {
            _cashSuper = cashSuper;
        }

        public double GetMoney(double money)
        {
            return _cashSuper.AcceptCash(money);
        }
    }
}