namespace SortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ArrayGenerator
    {
        public int[] output;
        public Random rd;

        public void RandomGenerator(int Length)
        {
            this.rd = new Random();
            this.output = new int[Length];
            var i = 0;
            while(i < Length)
            {
                this.output[i] = rd.Next(-Length,Length);
                i++;
            }
        }

        public void AscendGenerator(int Length)
        {
            this.output = new int[Length];
            var i = 0;
            while (i < Length)
            {
                this.output[i] = i;
                i++;
            }
        }

        public void DescendGenerator(int Length)
        {
            this.output = new int[Length];
            var i = Length;
            while (i > 0)
            {
                this.output[Length - i] = i - 1;
                i--;
            }
        }

        public void NoDupGenerator(int Length)
        {
            this.output = new int[Length];
            var i = Length;
            while (i > 0)
            {
                this.output[Length - i] = i - 1;
                i--;
            }
        }
    }
}
