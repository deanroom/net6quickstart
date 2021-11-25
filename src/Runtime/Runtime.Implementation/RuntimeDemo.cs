using Runtime.Abstractions;

namespace Runtime.Implementation
{
    public class RuntimeDemo:IRuntime
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public bool State { get; set; }

        public void On()
        {
            State = true;
        }

        public void Off()
        {
            State = false;
        }
    }
}