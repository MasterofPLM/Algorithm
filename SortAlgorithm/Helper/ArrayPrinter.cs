namespace SortAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ArrayPrinter
    {
        public void Print(int[] inputArray)
        {
            if (inputArray == null)
            {
                Console.WriteLine("[]");
            }

            string formatString = "[";
            foreach (var i in inputArray)
            {
                formatString += i + " ";
            }
            formatString.Trim();
            formatString += "]";
            Console.WriteLine(formatString);
        }
    }
}
