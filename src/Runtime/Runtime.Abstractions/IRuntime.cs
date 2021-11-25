namespace Runtime.Abstractions
{
    public interface IRuntime
    {
        string Name { get; set; }
        bool State { get; set; }
        void On();
        void Off();
    }
}