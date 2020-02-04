namespace Args
{
    public abstract class IEngineState
    {
        protected IEngineState(object config)
        {
            Config = config;
        }
        public abstract IEngineState Accept(string s);
        public object Config { get; set; }
    }

    public class EngineReady : IEngineState
    {
        public EngineReady(object config) : base(config)
        {
        }

        public override IEngineState Accept(string s)
        {
            return new EngineReadyWaitingShortScheme(this.Config);
        }
    }

    public class EngineReadyWaitingShortScheme : IEngineState
    {
        public EngineReadyWaitingShortScheme(object config): base(config)
        {
        }

        public override IEngineState Accept(string s)
        {
            throw new System.NotImplementedException();
        }
    }
}