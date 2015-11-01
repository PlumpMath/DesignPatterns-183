using System;

namespace FacadePattern
{
    public class Facade
    {
        private readonly SubSystemFour _four;
        private readonly SubSystemOne _one;
        private readonly SubSystemThree _three;
        private readonly SubSystemTwo _two;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine($"{Environment.NewLine}方法组A---");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine($"{Environment.NewLine}方法组B---");
            _two.MethodTwo();
            _three.MethodThree();
        }
    }
}