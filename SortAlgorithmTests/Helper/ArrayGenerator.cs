namespace SortAlgorithm.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ArrayGenerator
    {
        public int[] output;
        public Random rd;

        public void Generate(int Length)
        {
            this.rd = new Random();
            this.output = new int[Length];
            var i = 0;
            while(i < Length)
            {
                this.output[i] = rd.Next();
                i++;
            }
        }
    }
}
