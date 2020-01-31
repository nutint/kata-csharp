using System;
namespace Args
{
    public class ArgScheme
    {
        public string Scheme { get; }

        public ArgScheme(string scheme)
        {
            Scheme = scheme;
        }
    }

    public class OptionScheme: ArgScheme
    {
        public static OptionScheme Of(string schemeName)
        {
            return new OptionScheme(schemeName);
        }

        private OptionScheme(string scheme): base(scheme) { }

        public Boolean isArgExists(string stringParam)
        {
            stringParam.Contains("xx");
            return stringParam.Contains(Scheme);
        }
    }
}
