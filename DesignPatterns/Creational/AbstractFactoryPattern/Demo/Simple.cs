using System;
using System.Globalization;

namespace AbstractFactoryPattern.Demo
{
    public class Simple
    {
        public Simple()
        {
            IFactory operFactory = new DivFactory();
            Operation oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 0;
            try
            {
                double result = oper.GetResult();
                Console.WriteLine(result.ToString(CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}