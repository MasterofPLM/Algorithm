namespace SortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class InsertSortV2 : SortMethod
    {
        public override void Sort(int[] inputArray)
        {
            if (inputArray == null)
            {
                return;
            }

            int length = inputArray.Length;
            for (int i = 1; i < length; i++)
            {
                var key = inputArray[i];
                int index = BinarySearch(inputArray, 0, i - 1, key);
                for (int j = index; j < i; j++)
                {
                    inputArray[j + 1] = inputArray[j];
                }
                inputArray[index] = key;
            }
        }

        private int BinarySearch(int[] inputArray, int startIndex, int endIndex, int target)
        {
            int start = startIndex;
            int end = endIndex;
            int mid;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (inputArray[mid] >= target && mid > 0 && inputArray[mid - 1] <= target)
                {
                    return mid;
                }
                else if (inputArray[mid] >= target && mid > 0)
                {
                    end = mid - 1;
                }
                else if (inputArray[mid] >= target && mid == 0)
                {
                    return 0;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
    }
}
