using System;
using Xunit;

namespace Args
{
    public class ArgEngineTest
    {
        [Fact]
        public void ShouldNotChangeConfig_WhenReceivingSingleDash()
        {
            var defaultConfig = new
            {
                logging = false,
                authorizationCheck = true,
                loggingOutputDir = "~",
                port = 8000,
            };

            IEngineState engineReady = new EngineReady(defaultConfig);
            IEngineState newEngineReady = engineReady.Accept("-");
            Assert.Equal(defaultConfig, actual: newEngineReady.Config);
            Assert.IsType<EngineReadyWaitingShortScheme>(newEngineReady);
        }
    }
}