using System;

namespace FactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var oper = OperationFactory.CreationOperation("/");
            oper.NumberA = 1;
            oper.NumberB = 0;
            try
            {
                Console.WriteLine(oper.GetResult());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());

            Console.ReadKey();
        }
    }
}