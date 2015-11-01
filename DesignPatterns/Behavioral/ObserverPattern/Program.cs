using System;
using ObserverPattern.demo;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();

            Console.WriteLine();
            new Demo();

            Console.ReadKey();
        }
    }
}