namespace SortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MergeSortV2 : SortMethod
    {
        private ArrayPrinter ap = new ArrayPrinter();
        private InsertSort insertSort = new InsertSort();

        public override void Sort(int[] inputArray)
        {
            if (inputArray == null)
            {
                return;
            }

            Merge(inputArray, 0, inputArray.Length - 1);
        }

        private void Merge(int[] inputArray, int start, int end, int k = 4)
        {
            if (start >= end)
            {
                return;
            }

            int mid = start + (end - start) / 2;
            int[] left = new int[mid - start + 1];
            int[] right = new int[end - mid];

            if (mid - start + 1 > k)
            {
                Merge(inputArray, start, mid);
                ap.CopyArrayToArray(inputArray, start, mid, left);
            }
            else
            {
                ap.CopyArrayToArray(inputArray, start, mid, left);
                this.insertSort.Sort(left);
            }
            
            if (end - mid > k)
            {
                Merge(inputArray, mid + 1, end);
                ap.CopyArrayToArray(inputArray, mid + 1, end, right);
            }
            else
            {
                ap.CopyArrayToArray(inputArray, mid + 1, end, right);
                this.insertSort.Sort(right);
            }

            int ind1 = 0;
            int ind2 = 0;
            int ind = start;
            int len1 = mid - start + 1;
            int len2 = end - mid;
            while (ind1 < len1 && ind2 < len2)
            {
                if (left[ind1] <= right[ind2])
                {
                    inputArray[ind] = left[ind1];
                    ind1++;
                    ind++;
                }
                else
                {
                    inputArray[ind] = right[ind2];
                    ind2++;
                    ind++;
                }

                if (ind1 == len1)
                {
                    if (ind2 < len2)
                    {
                        ap.CopyArrayToArray(
                            right,
                            ind2,
                            len2 - 1,
                            inputArray,
                            ind,
                            ind + len2 - ind2 - 1);
                    }
                    ind1++;
                }

                if (ind2 == len2)
                {
                    if (ind1 < len1)
                    {
                        ap.CopyArrayToArray(
                            left,
                            ind1,
                            len1 - 1,
                            inputArray,
                            ind,
                            ind + len1 - ind1 - 1);
                    }
                    ind2++;
                }
            }
            return;
        }
    }
}
