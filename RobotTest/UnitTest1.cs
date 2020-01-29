using System;
using Xunit;

namespace RobotTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Add(2, 2));
        }
    }
}
