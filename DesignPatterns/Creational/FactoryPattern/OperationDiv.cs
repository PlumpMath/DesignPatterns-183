using System;

namespace FactoryPattern
{
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (Math.Abs(NumberB) <= 0)
            {
                throw new DivideByZeroException($"{NumberB}不能为0");
            }
            return NumberA / NumberB;
        }
    }
}