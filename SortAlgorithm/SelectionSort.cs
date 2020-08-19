namespace SortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SelectionSort: SortMethod
    {
        public override void Sort(int[] inputArray)
        {
            if (inputArray == null)
            {
                return;
            }

            int length = inputArray.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int index = i;
                for (int j = i; j < length; j++)
                {
                    if (inputArray[j] < inputArray[index])
                    {
                        index = j;
                    }
                }
                var tmp = inputArray[i];
                inputArray[i] = inputArray[index];
                inputArray[index] = tmp;
            }
        }
    }
}
