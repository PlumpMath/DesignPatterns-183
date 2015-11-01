namespace ObserverPattern.demo
{
    public class Boss : ISubject
    {
        public delegate void EventHandler();

        public void Notify()
        {
            Update();
        }

        public string SubjectState { get; set; }

        /// <summary>
        ///     声明一个事件Update，类型为委托EventHandler
        /// </summary>
        public event EventHandler Update;
    }
}