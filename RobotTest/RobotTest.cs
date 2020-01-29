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
            var robot = new Robot.Robot();
            Assert.Equal(4, robot.Add(2, 2));
        }

        [Fact]
        public void TestInput() 
        {
            const string input = @"10\nquit";

            var robot = new Robot.Robot(input);

        }
    }
}
