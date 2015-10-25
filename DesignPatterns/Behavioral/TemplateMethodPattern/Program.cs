using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass c = new ConcreteClassA();
            c.TemplateMethod();
           
            c = new ConcreteClassB();
            c.TemplateMethod();

            Console.ReadKey();
        }
    }
}
