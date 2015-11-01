using System;

namespace PrototypePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new ConcretePrototype1("I");
            var p2 = (ConcretePrototype1) p1.Clone();

            Console.WriteLine($"befor clone, Id={p1.Id}");
            Console.WriteLine($"after clone, Id={p2.Id}");

            Console.ReadKey();
        }
    }
}