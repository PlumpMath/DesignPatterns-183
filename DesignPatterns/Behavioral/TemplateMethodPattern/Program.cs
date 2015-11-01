using System;

namespace TemplateMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AbstractClass c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();

            Console.ReadKey();
        }
    }
}