using System;

namespace AdapterPattern
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }
}