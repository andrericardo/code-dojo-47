using System;
using Xunit;
using Robot;

namespace RobotTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var robot = new Class1();
            Assert.Equal(4, robot.Add(2, 2));
        }
    }
}
