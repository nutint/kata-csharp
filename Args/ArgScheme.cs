using System;
using System.Collections.Immutable;
using System.Linq;

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

        public bool IsArgExists(string stringParam)
        {
            return stringParam
                .Split(" ")
                .Select(element => element.Trim()).ToList()
                .Exists(x => x == $"-{Scheme}");
        }
    }

    public class StringScheme: ArgScheme
    {
        public static StringScheme Of(string schemeName)
        {
            return new StringScheme(schemeName);
        }

        private StringScheme(string scheme): base(scheme) { }

        public IImmutableList<string> ExtractValue(string stringParam)
        {
            return ImmutableList.Create("stringValue");
        }
    }
}
