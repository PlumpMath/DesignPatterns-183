﻿namespace AbstractFactoryPattern.Demo
{
    public class AddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}