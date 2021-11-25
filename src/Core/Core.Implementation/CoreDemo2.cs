using Core.Abstractions;
using Device.Abstractions;
using Framework.Abstractions;

namespace Core.Implementation
{
    public class CoreDemo2:ICore
    {
        private readonly IFramework _framework;
        private readonly IDevice _device;

        public CoreDemo2(IFramework framework, IDevice device)
        {
            _framework = framework;
            _device = device;
        }

        public string Name { get; set; }


        public void Start()
        {
            _device.WriteCode($"[{nameof(CoreDemo2)}-Start()] said '动起来'");
        }

        public void Stop()
        {
            _device.WriteCode($"[{nameof(CoreDemo2)}-Stop()] said '立定'");
        }

        public void Abort()
        {
            _device.WriteCode($"[{nameof(CoreDemo2)}-Abort()] said '急刹，停车。'");
        }

        public void Do(string message)
        {
            var result = _device.ReadCode();
            _framework.Info($"[{nameof(CoreDemo2)}-Do()] 获取指令 [{message}] 从Device拿到回复：[{result}]");
        }
    }
}