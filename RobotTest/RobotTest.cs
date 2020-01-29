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
        public void TestNumberOfBlocks_InputTwo_ReturnsTwo()
        {
            var robot = new Robot.Robot(2);

            //const string expectedOutput = @"0:0\n1:1\2:2";
            var output = robot.NumberOfBlocks();

            Assert.Equal(2, output);
        }

        [Fact]
        public void TestOutput_InputTwo_ReturnsTwo()
        {
            var robot = new Robot.Robot(2);

            var n = Environment.NewLine;
            var expectedOutput = $"0: 0{n}1: 1{n}2: 2{n}";
            var output = robot.Output();

            Assert.Equal(expectedOutput, output);
        }
    }
}
