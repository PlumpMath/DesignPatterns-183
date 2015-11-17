namespace MementoPattern
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }
    }
}