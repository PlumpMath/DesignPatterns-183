using System;

namespace ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private readonly string _name;
        private string _observerState;
        public ConcreteSubject Subject { get; set; }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Subject = subject;
            _name = name;
        }

        public override void Update()
        {
            _observerState = Subject.SubjectState;
            Console.WriteLine($"观察者{_name}的新状态是{_observerState}");
        }
    }
}