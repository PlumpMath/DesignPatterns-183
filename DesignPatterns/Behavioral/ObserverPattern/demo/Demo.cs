namespace ObserverPattern.demo
{
    public class Demo
    {
        public Demo()
        {
            Boss boss = new Boss();
            StockObserver stockObserver = new StockObserver("小魏", boss);
            NbaObserver nbaObserver = new NbaObserver("小易", boss);
            OtherObserver otherObserver = new OtherObserver();

            boss.Update += stockObserver.CloseStockMarket;
            boss.Update += nbaObserver.CloseNbaDirectSeeding;
            boss.Update += otherObserver.Other;

            boss.SubjectState = "我胡汉三回来了";
            //boss.Update -= stockObserver.CloseStockMarket;
            boss.Notify();
        }
    }
}