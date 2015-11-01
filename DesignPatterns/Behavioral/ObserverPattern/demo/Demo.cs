namespace ObserverPattern.demo
{
    public class Demo
    {
        public Demo()
        {
            var boss = new Boss();
            var stockObserver = new StockObserver("小魏", boss);
            var nbaObserver = new NbaObserver("小易", boss);
            var otherObserver = new OtherObserver();

            boss.Update += stockObserver.CloseStockMarket;
            boss.Update += nbaObserver.CloseNbaDirectSeeding;
            boss.Update += otherObserver.Other;

            boss.SubjectState = "我胡汉三回来了";
            //boss.Update -= stockObserver.CloseStockMarket;
            boss.Notify();
        }
    }
}