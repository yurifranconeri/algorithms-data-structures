using System;

namespace InterpolationSearch
{
    public class InterpolationSearch
    {
        public static int Search(int[] values, int valueToFind)
        {            
            if (values == null || values.Length < 1 ||
                values[values.Length-1] < valueToFind || values[0] > valueToFind)
            {
                return -1;
            }

            if (values.Length == 1)
            {
                return values[0] == valueToFind ? 0 : -1;
            }

            return InterpolationSearching(values, valueToFind, 0, values.Length - 1);
        }

        private static int InterpolationSearching(int[] values, int valueToFind, int startIndex, int finalIndex)
        {
            var lowerValue = values[startIndex];
            var higherValue = values[finalIndex];

            int positionFormula = startIndex + (finalIndex - startIndex) * (valueToFind - lowerValue) / (higherValue - lowerValue);

            if (finalIndex <= startIndex)
            {
                return -1;
            }

            if (values[positionFormula] == valueToFind)
            {
                return positionFormula;
            }

            if (values[positionFormula] < valueToFind)
            {
                return InterpolationSearching(values, valueToFind, positionFormula+1, finalIndex);
            }

            if (values[positionFormula] > valueToFind)
            {
                return InterpolationSearching(values, valueToFind, startIndex, positionFormula-1);
            }

            return -1;
        }
    }
}
    