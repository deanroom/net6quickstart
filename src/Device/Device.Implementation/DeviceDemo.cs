using System;
using System.Linq;
using Device.Abstractions;
using Framework.Abstractions;
using Runtime.Abstractions;

namespace Device.Implementation
{
    public class DeviceDemo:IDevice
    {
        private readonly IRuntime _runtime;
        private readonly IFramework _framework;
        public DeviceDemo(IRuntime runtime, IFramework framework)
        {
            _runtime = runtime;
            _framework = framework;
        }

        public string Name { get; set; }
        public void WriteCode(string code)
        {
            _framework.Info($"[{nameof(DeviceDemo)}]:向驱动下发报文 ##{code}##.");
        }

        public string ReadCode()
        {
            return $"[{nameof(DeviceDemo)}]:从DRIVER获取报文回复##{RandomString(10)}##.";
        }
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var  random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
    }
}