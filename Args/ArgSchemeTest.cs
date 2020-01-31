using System;
using Xunit;

namespace Args
{
    public class ArgSchemeTest
    {
        [Fact]
        public void Returns_True_When_Found_Argument()
        {
            string stringArgument = "-l";
            OptionScheme optionScheme = OptionScheme.Of("l");

            bool result = optionScheme.isArgExists(stringArgument);
            Assert.True(result);
        }

        [Fact]
        public void Returns_False_When_Not_Found_Argument()
        {
            string stringArgument = "-l";
            OptionScheme optionScheme = OptionScheme.Of("d");

            bool result = optionScheme.isArgExists(stringArgument);
            Assert.False(result);
        }
    }
}
