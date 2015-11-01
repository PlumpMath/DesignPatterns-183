using System;

namespace StatePattern
{
    public class Context
    {
        private State _state;

        public State State
        {
            get { return _state; } 
            set
            {
                _state = value;
                Console.WriteLine($"当前状态：{_state.GetType().Name}");
            }
        }

        public Context(State state)
        {
            State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}