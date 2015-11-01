namespace FactoryPattern
{
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA*NumberB;
        }
    }
}