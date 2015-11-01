using System;

namespace FacadePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }
}