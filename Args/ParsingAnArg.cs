namespace Args
{
    public class ParsingAnArg: IEngineState
    {
        public IEngineState accept(string s)
        {
            return this;
        }

        public IEngineState FinishParsing()
        {
            return new EngineReady();
        }
    }
}