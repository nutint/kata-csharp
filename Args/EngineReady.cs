namespace Args
{
    public class EngineReady : IEngineState
    {
        public IEngineState accept(string s)
        {
            if (s == " ")
            {
                return this;
            }
            else
            {
                return new ParsingAnArg();
            }
        }
    }
}