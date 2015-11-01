namespace ObserverPattern.demo
{
    public interface ISubject
    {
        string SubjectState { get; set; }
        void Notify();
    }
}