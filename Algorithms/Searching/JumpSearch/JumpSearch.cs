using System;

namespace JumpSearch
{
    public class JumpSeach
    {
        public static int Search(int[] values, int valueToFind)
        {
            if (values == null || values.Length < 1 || values[values.Length - 1] < valueToFind)
            {
                return -1;
            }
            return JumpSearch(values, valueToFind, (int)Math.Sqrt(values.Length + 1));
        }

        private static int JumpSearch(int[] values, int valueToFind, int jump)
        {
            var index = 0;
            while (values[Math.Min(jump, values.Length - 1)] < valueToFind)
            {
                index = jump;
                jump += jump;                
            }
            while (index <= jump)
            {
                if (values[index] == valueToFind)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
    }
}
