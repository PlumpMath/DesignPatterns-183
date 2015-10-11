namespace StrategyPattern
{
    public class CashContext
    {
        private readonly CashSuper _cashSuper;

        public CashContext(string type)
        {
            switch (type)
            {
                case "打八折":
                    _cashSuper = new CashRebate("0.8");
                    break;
                case "满300返100":
                    _cashSuper = new CashReturn("300", "100");
                    break;
                default:
                    _cashSuper = new CashNormal();
                    break;
            }
        }

        public double GetResult(double money)
        {
            return _cashSuper.AcceptCash(money);
        }
    }
}