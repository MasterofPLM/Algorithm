using System;
using System.Collections;
using System.Collections.Generic;

namespace SortAlgorithm
{
    public abstract class SortMethod
    {
        protected int[] arrayToSort;

        public abstract int[] Sort(int[] inputArray);
    }
}