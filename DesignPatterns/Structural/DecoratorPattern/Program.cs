using System;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var c = new ConcreteComponent();
            var a = new ConcreteDecoratorA();
            var b = new ConcreteDecoratorB();

            c.Operation();

            a.SetComponent(c);
            a.Operation();

            b.SetComponent(a);
            b.Operation();

            Console.ReadKey();
        }
    }
}