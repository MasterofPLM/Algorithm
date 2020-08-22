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

        public void CopyArrayToArray(
            int[] source,
            int sourceStart,
            int sourceEnd,
            int[] target,
            int targetStart,
            int targetEnd)
        {
            if (sourceEnd - sourceStart != targetEnd - targetStart)
            {
                Console.WriteLine("Copy fail. Length of source differs from target. ");
                return;
            }

            try
            {
                for (int i = 0; i <= sourceEnd - sourceStart; i++)
                {
                    target[targetStart + i] = source[sourceStart + i];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Copy Array failed. " + e.Message);
            }
        }

        public void CopyArrayToArray(int[] source, int[] target)
        {
            CopyArrayToArray(
                source,
                0,
                source.Length - 1,
                target,
                0,
                target.Length - 1);
        }

        public void CopyArrayToArray(int[] source, int sourceStart, int sourceEnd, int[] target)
        {
            CopyArrayToArray(
                source,
                sourceStart,
                sourceEnd,
                target,
                0,
                target.Length - 1);
        }
    }
}
