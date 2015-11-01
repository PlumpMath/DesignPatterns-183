namespace AbstractFactoryPattern.Demo
{
    public class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}