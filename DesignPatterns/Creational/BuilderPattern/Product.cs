using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Product
    {
        IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine($"{Environment.NewLine}产品 创建 ----");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}