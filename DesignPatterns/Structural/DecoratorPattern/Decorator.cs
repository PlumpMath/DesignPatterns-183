namespace DecoratorPattern
{
    public abstract class Decorator : Component
    {
        protected Component Component;

        public void SetComponent(Component component)
        {
            Component = component;
        }

        public override void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }
    }
}