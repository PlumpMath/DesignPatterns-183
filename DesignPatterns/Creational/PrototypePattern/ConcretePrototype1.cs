﻿namespace PrototypePattern
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype) MemberwiseClone();
        }
    }
}