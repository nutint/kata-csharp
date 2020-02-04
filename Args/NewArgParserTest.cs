using Xunit;

namespace Args
{
    public class NewArgParserTest
    {
        [Fact]
        public void EngineReady_Accepts_Dash_Should_Become_ParsingAnArg()
        {
            // Init
            var initialState = new EngineReady();

            // Action
            var nextState = initialState.accept("-");
            
            // Assertion
            Assert.IsType<ParsingAnArg>(nextState);
        }
        
        [Fact]
        public void EngineReady_Accepts_Space_Should_Become_EngineReady()
        {
            // Init
            var initialState = new EngineReady();

            // Action
            var nextState = initialState.accept(" ");
            
            // Assertion
            Assert.IsType<EngineReady>(nextState);
        }

        [Fact]
        void ParsingAnArg_Done_Parsing_Should_Become_EngineReady()
        {
            // Init
            var initialState = new ParsingAnArg();

            // Action
            var nextState = initialState.FinishParsing();
            
            // Assertion
            Assert.IsType<EngineReady>(nextState);
        }
    }
}