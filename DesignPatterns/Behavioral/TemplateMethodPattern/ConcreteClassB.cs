﻿using System;

namespace TemplateMethodPattern
{
    public class ConcreteClassB:AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体累B方法1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类B方法2实现");
        }
    }
}