namespace StrategyPattern.Money
{
    public class CashRebate : CashSuper
    {
        private double _moneyRebate;

        public CashRebate(double moneyRebate)
        {
            _moneyRebate = moneyRebate;
        }

        public override double AcceptCash(double money)
        {
            return money * _moneyRebate;
        }
    }
}