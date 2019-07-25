using System;
using System.Collections.Generic;
using System.Text;

namespace LinearSearch
{
    public static class LinearSearch
    {
        public static void Main(string[] args)
        {

        }

        public static int Search(int[] arrayValues, int valueToFind)
        {
            for (int index = 0; index < arrayValues.Length; index++)
            {
                if (arrayValues[index] == valueToFind)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
