using System.Runtime.InteropServices;

namespace Framework.Abstractions
{
    public interface IFramework
    {
        void Trace(string message);
        void Info(string message);
        string Localize(string code);
    }
}