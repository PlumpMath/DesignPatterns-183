using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA a = new ConcreteDecoratorA();
            ConcreteDecoratorB b = new ConcreteDecoratorB();

            c.Operation();

            a.SetComponent(c);
            a.Operation();

            b.SetComponent(a);
            b.Operation();

            Console.ReadKey();
        }
    }
}
