namespace ProxyPattern
{
    public class Proxy : Subject
    {
        private RealSubject relRealSubject;
        
        public override void Request()
        {
            if (relRealSubject == null)
            {
                relRealSubject = new RealSubject();
            }
            relRealSubject.Request();
        }
    }
}