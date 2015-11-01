using System;
using System.Globalization;

namespace AbstractFactoryPattern.Demo
{
    public class Simple
    {
        public Simple()
        {
            IFactory operFactory = new DivFactory();
            var oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 0;
            try
            {
                var result = oper.GetResult();
                Console.WriteLine(result.ToString(CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}