using System;
using Xunit;
using Robot;

namespace RobotTest
{
    public class RobotTest
    {
        [Fact]
        public void Test1()
        {
            var robot = new Class1();
            Assert.Equal(4, robot.Add(2, 2));
        }
    }
}
