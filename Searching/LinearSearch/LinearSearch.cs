using System;
using System.Collections.Generic;
using System.Text;

namespace LinearSearch
{
    public class LinearSearch
    {

        public static int Search(int[] arrayValues, int valueToFind)
        {
            if (arrayValues == null || arrayValues.Length < 1)
            {
                return -1;
            }
            return LinearSearching(arrayValues, valueToFind);
        }

        private static int LinearSearching(int[] arrayValues, int valueToFind)
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
