namespace SortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BubbleSort : SortMethod
    {
        public override void Sort(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 1)
            {
                return;
            }

            int length = inputArray.Length;
            int tmp;
            for (int i = 0; i < length; i++) 
            {
                for (int j = length - 1; j > i; j--)
                {
                    if (inputArray[j] < inputArray[j - 1])
                    {
                        tmp = inputArray[j];
                        inputArray[j] = inputArray[j - 1];
                        inputArray[j - 1] = tmp;
                    }
                }
            }
        }
    }
}
