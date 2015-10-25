namespace AbstractFactoryPattern
{
    public class SubFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}