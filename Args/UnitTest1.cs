using System;
using Xunit;

namespace Args
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => Assert.Equal(1, 1);

        [Fact]
        public void One_Plus_One_Should_Be_Two()
        {
            Assert.Equal(1 + 1, 2);
        }
    }
}
