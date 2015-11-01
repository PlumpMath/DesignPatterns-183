using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Product
    {
        private readonly IList<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine($"{Environment.NewLine}产品 创建 ----");
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}