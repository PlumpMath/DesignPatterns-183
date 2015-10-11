namespace StrategyPattern
{
    public class CashRebate : CashSuper
    {
        private readonly double _moneyRebate;

        public CashRebate(string moneyRebate)
        {
            _moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * _moneyRebate;
        }
    }
}