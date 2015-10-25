using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 p2 = (ConcretePrototype1)p1.Clone();

            Console.WriteLine($"befor clone, Id={p1.Id}");
            Console.WriteLine($"after clone, Id={p2.Id}");

            Console.ReadKey();
        }
    }
}
