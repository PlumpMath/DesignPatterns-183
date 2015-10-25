namespace AbstractFactoryPattern
{
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}