using System;

namespace DecoratorPattern
{
    public class ConcreteDecoratorA : Decorator
    {
        private string _addedState;

        public override void Operation()
        {
            base.Operation();
            _addedState = "New State";
            Console.WriteLine(_addedState);
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}