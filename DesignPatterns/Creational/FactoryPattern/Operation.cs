using System.Runtime.Remoting.Channels;

namespace FactoryPattern
{
    public class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            return 0;
        }
    }
}