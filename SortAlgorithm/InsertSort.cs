namespace SortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using SortAlgorithm;

    public class InsertSort: SortMethod
    {
        public override int[] Sort(int[] inputArray)
        {
            this.arrayToSort = inputArray;
            if(this.arrayToSort == null)
            {
                return null;
            }

            int length = this.arrayToSort.Length;
            for(int i = 1; i < length; i++)
            {
                for(int j = i - 1; j >= 0; j--)
                {
                    if(this.arrayToSort[j] > this.arrayToSort[j + 1])
                    {
                        var tmp = this.arrayToSort[j + 1];
                        this.arrayToSort[j + 1] = this.arrayToSort[j];
                        this.arrayToSort[j] = tmp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return this.arrayToSort;
        }
    }
}
