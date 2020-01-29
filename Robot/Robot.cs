using System;

namespace Robot
{
    public class Robot
    {
        private string _input;

        public Robot(string input)
        {
            _input = input;
        }

        public int Add(int x, int y) {
            return x + y;
        }
    }
}
