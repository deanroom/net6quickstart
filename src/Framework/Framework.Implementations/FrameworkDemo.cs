using System;
using Framework.Abstractions;
using Microsoft.Extensions.Logging;

namespace Framework.Implementations
{
    public class FrameworkDemo:IFramework
    {
        private readonly ILogger _logger;

        public FrameworkDemo(ILogger<FrameworkDemo> logger)
        {
            _logger = logger;
        }

        public void Trace(string message)
        {
            _logger.LogTrace(message);
        }

        public void Info(string message)
        {
            _logger.LogWarning(message);
        }

        public string Localize(string code)
        {
            var message = $"Localized content of [{code}]";
            _logger.LogInformation(message);
            return message;
        }
    }
}