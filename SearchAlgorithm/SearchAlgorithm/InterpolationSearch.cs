namespace SearchAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InterpolationSearch : SearchMethod
    {
        public override int Search(int[] inputArray, int target)
        {
            if (inputArray == null || inputArray.Length == 0 || target < inputArray[0] || target > inputArray[inputArray.Length - 1]) 
            {
                return -1;
            }

            int start = 0;
            int end = inputArray.Length - 1;
            int mid;
            while (start <= end)
            {
                mid = start + ((target - inputArray[start]) / (inputArray[end] - inputArray[start]) * (end - start));
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
