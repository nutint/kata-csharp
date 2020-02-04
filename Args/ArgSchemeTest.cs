using System;
using Xunit;

namespace Args
{
    public class ArgSchemeTest
    {
        [Fact]
        public void Returns_True_When_Found_Argument()
        {
            OptionScheme optionScheme = OptionScheme.Of("l");
            bool result = optionScheme.IsArgExists("-l");
            Assert.True(result);
        }

        [Fact]
        public void Returns_False_When_Not_Found_Argument()
        {
            OptionScheme optionScheme = OptionScheme.Of("d");
            bool result = optionScheme.IsArgExists("-l");
            Assert.False(result);
        }

        [Fact]
        public void Returns_False_When_Args_Not_Fully_Matched()
        {
            OptionScheme optionScheme = OptionScheme.Of("l");
            var result = optionScheme.IsArgExists("-ll -aa");
            Assert.False(result);
        }
    }
}
