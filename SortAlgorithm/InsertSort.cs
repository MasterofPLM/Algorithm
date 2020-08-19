namespace SortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using SortAlgorithm;

    public class InsertSort: SortMethod
    {
        public override void Sort(int[] inputArray)
        {
            if(inputArray == null)
            {
                return;
            }

            int length = inputArray.Length;
            for(int i = 1; i < length; i++)
            {
                var key = inputArray[i];
                int j = i - 1;
                while (j >= 0)
                {
                    if(inputArray[j] > key)
                    {
                        inputArray[j + 1] = inputArray[j];
                    }
                    else
                    {
                        break;
                    }
                    j--;
                }
                inputArray[j + 1] = key;
            }
        }
    }
}
