namespace ProxyPattern
{
    public class Proxy : Subject
    {
        private RealSubject _relRealSubject;
        
        public override void Request()
        {
            if (_relRealSubject == null)
            {
                _relRealSubject = new RealSubject();
            }
            _relRealSubject.Request();
        }
    }
}