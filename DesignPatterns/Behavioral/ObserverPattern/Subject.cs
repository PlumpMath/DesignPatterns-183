using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class Subject
    {
        private readonly IList<Observer> _observers = new List<Observer>();

        /// <summary>
        ///     增加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        ///     移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        ///     通知
        /// </summary>
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}