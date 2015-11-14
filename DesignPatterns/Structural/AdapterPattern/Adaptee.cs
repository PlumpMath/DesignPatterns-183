using System;

namespace AdapterPattern
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求！");
        }
    }
}