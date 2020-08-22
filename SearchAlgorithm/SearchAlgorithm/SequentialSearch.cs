namespace SearchAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using SortAlgorithm;

    public class SequentialSearch : SearchMethod
    {
        public override int Search(int[] inputArray, int target)
        {
            if (inputArray == null)
            {
                return -1;
            }

            int length = inputArray.Length;
            for (int i = 0; i < length; i++)
            {
                if (inputArray[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
