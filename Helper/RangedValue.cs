using System;

namespace Ecapsulation
{
    internal class RangedValue
    {
        private string name;
        private int min;
        public int Max => max;
        private int max;
        public int Current => current;
        private int current;

        public RangedValue(string name, int min, int max, int current)
        {
            this.name = name;
            this.min = min;
            this.max = max;
            this.current = current;
        }
        public void Increase(int value)
        {
            current += value;
            if (current > max)
            {
                current = max;
            }
        }
        public void Decrease(int value)
        {
            current -= value;
            if (current < min)
            {
                current = min;
            }
        }
    }
}