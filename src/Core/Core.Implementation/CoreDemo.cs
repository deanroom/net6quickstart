using Core.Abstractions;
using Device.Abstractions;
using Framework.Abstractions;

namespace Core.Implementation
{
    public class CoreDemo:ICore
    {
        private readonly IFramework _framework;
        private readonly IDevice _device;

        public CoreDemo(IFramework framework, IDevice device)
        {
            _framework = framework;
            _device = device;
        }

        public string Name { get; set; }
        public void Start()
        {
            _device.WriteCode($"[{nameof(CoreDemo)}-Start()] said '动起来'");
        }

        public void Stop()
        {
            _device.WriteCode($"[{nameof(CoreDemo)}-Stop()] said '立定'");
        }

        public void Abort()
        {
            _device.WriteCode($"[{nameof(CoreDemo)}-Abort()] said '急刹，停车。'");
        }

        public void Do(string message)
        {
            var result = _device.ReadCode();
            _framework.Info($"[{nameof(CoreDemo)}-Do()] 获取指令 [{message}] 回复内容 [{result}]");
        }
    }
}