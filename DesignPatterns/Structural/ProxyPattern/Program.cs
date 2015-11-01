using System;

namespace ProxyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = new Proxy();
            proxy.Request();

            proxy.Request();

            Console.ReadKey();
        }
    }
}