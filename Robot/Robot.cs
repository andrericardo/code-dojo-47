using System;
using System.Collections;

namespace Robot
{
    public class Robot
    {
        private Stack _blocks;

        public Robot()
        {
        }

        public Robot(int numberOfBlocks)
        {
            _blocks = new Stack();
            for(int i = 0; i < numberOfBlocks; i++) {
                _blocks.Push(i);
            }
        }

        public int Add(int x, int y) {
            return x + y;
        }

        public int NumberOfBlocks()
        {
            return _blocks.Count;
        }

        public string Output()
        {
            var result = "";

            for(int i = 0; i <= NumberOfBlocks(); i++) {
                result += $"{i}: {i}" + Environment.NewLine;
            }

            return result;
        }
    }
}
