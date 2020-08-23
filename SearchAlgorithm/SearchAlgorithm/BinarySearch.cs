namespace SearchAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BinarySearch : SearchMethod
    {
        public override int Search(int[] inputArray, int target)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                return -1;
            }

            int start = 0;
            int end = inputArray.Length - 1;
            int mid;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (inputArray[mid] < target)
                {
                    start = mid + 1;
                }
                else if (inputArray[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
