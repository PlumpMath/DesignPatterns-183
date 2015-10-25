namespace PrototypePattern
{
    public abstract class Prototype
    {
        public string Id { get; set; }

        public Prototype(string id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }
}