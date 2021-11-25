namespace Device.Abstractions
{
    public interface IDevice
    {
        string Name { get; set; }

        void WriteCode(string code);

        string ReadCode();

    }
}