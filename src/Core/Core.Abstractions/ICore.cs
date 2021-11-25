namespace Core.Abstractions
{
    public interface ICore
    {
        public string Name { get; set; }

        void Start();

        void Stop();

        void Abort();

        void Do(string message);
    }
}