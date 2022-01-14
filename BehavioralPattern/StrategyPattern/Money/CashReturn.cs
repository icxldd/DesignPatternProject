namespace StrategyPattern.Money
{
    public class CashReturn : CashSuper
    {
        private double _moneyConditation;
        private double _moneyReturn;

        public CashReturn(double moneyConditation, double moneyReturn)
        {
            _moneyConditation = moneyConditation;
            _moneyReturn = moneyReturn;
        }

        public override double AcceptCash(double money)
        {
            if (money >= _moneyConditation)
            {
                return money - _moneyReturn;
            }
            else
            {
                return money;
            }
        }
    }
}