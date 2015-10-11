using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = OperationFactory.CreationOperation("/");
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
