namespace ObserverPattern.demo
{
    public interface ISubject
    {
        void Notify();
        string SubjectState { get; set; }
    }
}