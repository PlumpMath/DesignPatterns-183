namespace BuilderPattern
{
    public class ConcreteBuilder2:Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("部件X");
        }

        public override void BuildPartB()
        {
            _product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}